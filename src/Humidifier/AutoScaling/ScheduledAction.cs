namespace Humidifier.AutoScaling
{
    using System.Collections.Generic;

    public class ScheduledAction : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AutoScaling::ScheduledAction";
            }
        }

        /// <summary>
        /// AutoScalingGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-as-scheduledaction.html#cfn-as-scheduledaction-asgname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AutoScalingGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// DesiredCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-as-scheduledaction.html#cfn-as-scheduledaction-desiredcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic DesiredCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// EndTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-as-scheduledaction.html#cfn-as-scheduledaction-endtime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EndTime
        {
            get;
            set;
        }

        /// <summary>
        /// MaxSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-as-scheduledaction.html#cfn-as-scheduledaction-maxsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxSize
        {
            get;
            set;
        }

        /// <summary>
        /// MinSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-as-scheduledaction.html#cfn-as-scheduledaction-minsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MinSize
        {
            get;
            set;
        }

        /// <summary>
        /// Recurrence
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-as-scheduledaction.html#cfn-as-scheduledaction-recurrence
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Recurrence
        {
            get;
            set;
        }

        /// <summary>
        /// StartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-as-scheduledaction.html#cfn-as-scheduledaction-starttime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StartTime
        {
            get;
            set;
        }
    }
}