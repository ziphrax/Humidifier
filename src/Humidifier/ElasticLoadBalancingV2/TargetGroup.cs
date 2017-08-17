namespace Humidifier.ElasticLoadBalancingV2
{
    using System.Collections.Generic;
    using TargetGroupPropertyTypes;

    public class TargetGroup : IResource
    {
        /// <summary>
        /// HealthCheckIntervalSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-healthcheckintervalseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? HealthCheckIntervalSeconds
        {
            get;
            set;
        }

        /// <summary>
        /// HealthCheckPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-healthcheckpath
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HealthCheckPath
        {
            get;
            set;
        }

        /// <summary>
        /// HealthCheckPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-healthcheckport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HealthCheckPort
        {
            get;
            set;
        }

        /// <summary>
        /// HealthCheckProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-healthcheckprotocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HealthCheckProtocol
        {
            get;
            set;
        }

        /// <summary>
        /// HealthCheckTimeoutSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-healthchecktimeoutseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? HealthCheckTimeoutSeconds
        {
            get;
            set;
        }

        /// <summary>
        /// HealthyThresholdCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-healthythresholdcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? HealthyThresholdCount
        {
            get;
            set;
        }

        /// <summary>
        /// Matcher
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-matcher
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Matcher
        /// </summary>
        public Matcher Matcher
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }

        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-port
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public int Port
        {
            get;
            set;
        }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-protocol
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Protocol
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }

        /// <summary>
        /// TargetGroupAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-targetgroupattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TargetGroupAttribute
        /// </summary>
        public List<TargetGroupAttribute> TargetGroupAttributes
        {
            get;
            set;
        }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-targets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TargetDescription
        /// </summary>
        public List<TargetDescription> Targets
        {
            get;
            set;
        }

        /// <summary>
        /// UnhealthyThresholdCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-unhealthythresholdcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? UnhealthyThresholdCount
        {
            get;
            set;
        }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html#cfn-elasticloadbalancingv2-targetgroup-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcId
        {
            get;
            set;
        }
    }

    namespace TargetGroupPropertyTypes
    {
        public class TargetGroupAttribute
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-targetgroupattributes.html#cfn-elasticloadbalancingv2-targetgroup-targetgroupattributes-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key
            {
                get;
                set;
            }

            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-targetgroupattributes.html#cfn-elasticloadbalancingv2-targetgroup-targetgroupattributes-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }
        }

        public class Matcher
        {
            /// <summary>
            /// HttpCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-matcher.html#cfn-elasticloadbalancingv2-targetgroup-matcher-httpcode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpCode
            {
                get;
                set;
            }
        }

        public class TargetDescription
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-targetdescription.html#cfn-elasticloadbalancingv2-targetgroup-targetdescription-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id
            {
                get;
                set;
            }

            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-targetdescription.html#cfn-elasticloadbalancingv2-targetgroup-targetdescription-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? Port
            {
                get;
                set;
            }
        }
    }
}