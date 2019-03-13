namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class VPCDHCPOptionsAssociation : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::VPCDHCPOptionsAssociation";
            }
        }

        /// <summary>
        /// DhcpOptionsId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html#cfn-ec2-vpcdhcpoptionsassociation-dhcpoptionsid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DhcpOptionsId
        {
            get;
            set;
        }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html#cfn-ec2-vpcdhcpoptionsassociation-vpcid
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
}