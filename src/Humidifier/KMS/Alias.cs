namespace Humidifier.KMS
{
    using System.Collections.Generic;
    using AliasPropertyTypes;

    public class Alias : IResource
    {
        /// <summary>
        /// AliasName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-alias.html#cfn-kms-alias-aliasname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AliasName
        {
            get;
            set;
        }

        /// <summary>
        /// TargetKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-alias.html#cfn-kms-alias-targetkeyid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetKeyId
        {
            get;
            set;
        }
    }

    namespace AliasPropertyTypes
    {
    }
}