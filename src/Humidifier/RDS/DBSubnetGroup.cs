namespace Humidifier.RDS
{
    using System.Collections.Generic;

    public class DBSubnetGroup : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::RDS::DBSubnetGroup";
            }
        }

        /// <summary>
        /// DBSubnetGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnet-group.html#cfn-rds-dbsubnetgroup-dbsubnetgroupdescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DBSubnetGroupDescription
        {
            get;
            set;
        }

        /// <summary>
        /// DBSubnetGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnet-group.html#cfn-rds-dbsubnetgroup-dbsubnetgroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DBSubnetGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnet-group.html#cfn-rds-dbsubnetgroup-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SubnetIds
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnet-group.html#cfn-rds-dbsubnetgroup-tags
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
    }
}