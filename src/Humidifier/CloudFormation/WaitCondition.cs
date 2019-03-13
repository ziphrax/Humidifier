namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;

    public class WaitCondition : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Data =  "Data" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CloudFormation::WaitCondition";
            }
        }

        /// <summary>
        /// Count
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html#cfn-waitcondition-count
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Count
        {
            get;
            set;
        }

        /// <summary>
        /// Handle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html#cfn-waitcondition-handle
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Handle
        {
            get;
            set;
        }

        /// <summary>
        /// Timeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html#cfn-waitcondition-timeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Timeout
        {
            get;
            set;
        }
    }
}