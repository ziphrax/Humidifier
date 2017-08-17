# Humidifier

Humidifier allows you to build AWS CloudFormation templates programmatically. Stacks and resources are represented as C# objects with accessors for all their supported properties.

Hat tip to the Ruby library https://github.com/localytics/humidifier

The code is automatically generated by parsing the official Cloudformation [specification](http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cfn-resource-specification.html).

## TODO
- [x] JSON Serialization
- [ ] YAML Serialization
- [ ] Resource attributes e.g `Fn.GetAttr("AutomationServiceRole", IAM.Role.Attributes.Arn)`

## Getting started

Stacks are represented by the Humidifier.Stack class. Resources are represented by an exact mapping from AWS resource names to Humidifier resources names (e.g. AWS::EC2::Instance becomes Humidifier.EC2.Instance). Resources have properties for each JSON attribute.

### Example usage
````csharp
using System.Collections.Generic;
using System.IO;
using Humidifier.Json;

namespace Humidifier.ConsoleTest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = BuildStack();

            var serializer = new JsonStackSerializer();
            var template = serializer.Serialize(stack);

            File.WriteAllText("cloudformation.template", template);
        }

        private static Stack BuildStack()
        {
            var stack = new Stack
            {
                AWSTemplateFormatVersion = "2010-09-09",
                Description = "Description"
            };

            stack.Add("Environment", new Parameter
            {
                Type = "String",
                Description = "Deployment environment",
                MinLength = 3,
                MaxLength = 4,
                AllowedValues = new List<string> { "test", "uat", "prod" },
                ConstraintDescription = "Allowed values: [test, uat, prod]"
            });

            stack.Add("AutomationStack", new Parameter
            {
                Type = "String",
                Description = "Automation stack name",
                MinLength = 1,
                MaxLength = 255,
                AllowedPattern = "^[a-zA-Z][-a-zA-Z0-9]*$",
                ConstraintDescription = "Must be a valid Cloudformation Stack name"
            });

            stack.Add("CodeS3Key", new Parameter
            {
                Type = "String",
                MinLength = 3
            });

            stack.Add("VPC", new EC2.VPC
            {
                CidrBlock = "10.0.0.0/16",
                EnableDnsSupport = false,
                EnableDnsHostnames = false,
                InstanceTenancy = "dedicated",
                Tags = new List<Tag>
                {
                    new Tag { Key = "foo", Value = "bar" }
                }
            });

            stack.Add("Subnet", new EC2.Subnet
            {
                VpcId = Fn.Ref("VPC"),
                CidrBlock = "10.0.0.0/24",
                AvailabilityZone = Fn.Select("0", Fn.GetAZs(Fn.Ref("AWS::Region")))
            });

            stack.Add("Ec2Instance", new EC2.Instance
            {
                ImageId = Fn.FindInMap("RegionMap", Fn.Ref("AWS::Region"), "64"),
                InstanceType = "m1.small",
                UserData = Fn.Base64(
                    @"#!/bin/bash -e
                    wget https://opscode-omnibus-packages.s3.amazonaws.com/ubuntu/12.04/x86_64/chef_11.6.2-1.ubuntu.12.04_amd64.deb
                    dpkg -i chef_11.6.2-1.ubuntu.12.04_amd64.deb"
                )
            });

            stack.Add("AutomationServiceRole", new IAM.Role
            {
                AssumeRolePolicyDocument = new PolicyDocument
                {
                    Statement = new List<Statement>
                    {
                        new Statement
                        {
                            Effect = "Allow",
                            Principal = new { Service = "cloudformation.amazonaws.com" },
                            Action = "sts:AssumeRole"
                        }
                    }
                }
            });

            stack.Add("DeploymentBucket", new S3.Bucket { BucketName = Fn.Ref("AWS::StackName") });
            stack.Add("DeploymentBucketPolicy", new S3.BucketPolicy
            {
                Bucket = Fn.Ref("DeploymentBucket"),
                PolicyDocument = new PolicyDocument
                {
                    Version = "2012-10-17",
                    Statement = new List<Statement>
                    {
                        new Statement
                        {
                            Effect = "Allow",
                            Principal = new
                            {
                               AWS = Fn.GetAttr("AutomationServiceRole", "Arn")
                            },
                            Action = "s3:*",
                            Resource = new[]
                            {
                                Fn.Join("", "arn:aws:s3:::", Fn.Ref("DeploymentBucket")),
                                Fn.Join("", "arn:aws:s3:::", Fn.Ref("DeploymentBucket"), "/*")
                            }
                        }
                    }
                }
            });

            stack.Add("LambdaFunction", new Lambda.Function
            {
                Timeout = 30,
                FunctionName = new { Ref = "AWS::StackName" },
                Runtime = "dotnetcore1.0",
                Description = "",
                Handler = "SomeProject::SomeProject.SomeFunction::FunctionHandler",
                MemorySize = 256,
                Code = new Code
                {
                    S3Bucket = Fn.ImportValue(Fn.Sub("${AutomationStack}-DeploymentBucket")),
                    S3Key = new { Ref = "CodeS3Key" },
                },
                Environment = new Environment
                {
                    Variables = new Dictionary<string, dynamic>
                    {
                        ["EnvironmentName"] = Fn.Ref("Environment")
                    }
                },
            });

            stack.Add("MonitoringSnsTopic", new SNS.Topic
            {
                DisplayName = Fn.Ref("AWS::StackName"),
                Subscription = new List<SNS.Subscription>
                {
                    new SNS.Subscription { Endpoint = "team@example.com", Protocol = "email" }
                }
            });

            stack.Add("KmsKey", new KMS.Key
            {
                Description = "A Key",
                KeyPolicy = new PolicyDocument
                {
                    Id = "key-default-1",
                    Version = "2012-10-17",
                    Statement = new List<Statement>
                    {
                        new Statement
                        {
                            Sid = "Allow the administration of the key",
                            Effect = "Allows",
                            Principal = new {AWS = "arn:aws:iam::123456789012:user/Alice"},
                            Action = new[]
                            {
                                "kms:Create*",
                                "kms:Describe*",
                                "kms:Enable*",
                                "kms:List*",
                                "kms:Put*",
                                "kms:Update*",
                                "kms:Revoke*",
                                "kms:Disable*",
                                "kms:Get*",
                                "kms:Delete*",
                                "kms:ScheduleKeyDeletion",
                                "kms:CancelKeyDeletion"
                            },
                            Resource = "*"
                        }
                    }
                }
            });

            var regionMap = new Mapping
            {
                ["us-east-1"] = new Dictionary<string, string> { ["32"] = "ami-6411e20d", ["64"] = "ami-7a11e213" },
                ["us-west-1"] = new Dictionary<string, string> { ["32"] = "ami-c9c7978c", ["64"] = "ami-cfc7978a" },
                ["ue-west-1"] = new Dictionary<string, string> { ["32"] = "ami-37c2f643", ["64"] = "ami-31c2f645" },
                ["ap-southeast-1"] = new Dictionary<string, string> { ["32"] = "ami-66f28c34", ["64"] = "ami-60f28c32" },
                ["ap-northeast-1"] = new Dictionary<string, string> { ["32"] = "ami-9c03a89d", ["64"] = "ami-a003a8a1" }
            };

            stack.Mappings.Add("RegionMap", regionMap);

            return stack;
        }
    }
}

````

### Functions

You can use CFN intrinsic functions and references using Fn.[name]. Those will build appropriate structures that know how to be dumped to CFN syntax appropriately.

```csharp
Fn.FindInMap("RegionMap", Fn.Ref("AWS::Region"), "64");
```

```csharp
Fn.GetAttr("MyElb", "DNSName");
```

```csharp
Fn.GetAZs("us-east-2");
```

```csharp
Fn.ImportValue(Fn.Sub("${NetworkStackNameParameter}-SubnetID"));
```

```csharp
Fn.Join("", "arn:aws:s3:::", Fn.Ref("DeployBucket"), "/*");
```

```csharp
Fn.Ref("BucketName");
```

```csharp
Fn.Select("1", new[] { "a", "b", "c" });
```

```csharp
Fn.Split("|", "a|b|c");
```

```csharp
Fn.Sub("${AWS::StackName}-${AWS::Region}-bucket");
```

```csharp
Fn.Select("1", Fn.Split("|", "a|b|c"));
```

```csharp
// Because JSON doesn't allow newlines, there's a known hack where you can join multiple lines together using Fn::Join
var fnBase64 = Fn.Base64(Fn.Join("",
    "#!/bin/bash -e\n",
    "wget https://opscode-omnibus-packages.s3.amazonaws.com/ubuntu/12.04/x86_64/chef_11.6.2-1.ubuntu.12.04_amd64.deb\n",
    "dpkg -i chef_11.6.2-1.ubuntu.12.04_amd64.deb\n"
));

// But that's gross and unreadable, we have a better way! Use a multiline C# string, and let the library take care of encoding it for you.
//  - Whitespace on the start of the line is trimmed, so feel free to indent you code nicely.
//  - Newlines are encoded as \r\n automatically by NewtonSoft.Json
var altBase64 = Fn.Base64(
    @"#!/bin/bash -e
    wget https://opscode-omnibus-packages.s3.amazonaws.com/ubuntu/12.04/x86_64/chef_11.6.2-1.ubuntu.12.04_amd64.deb
    dpkg -i chef_11.6.2-1.ubuntu.12.04_amd64.deb"
);
````