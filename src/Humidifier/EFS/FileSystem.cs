namespace Humidifier.EFS
{
    using System.Collections.Generic;
    using FileSystemTypes;

    public class FileSystem : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EFS::FileSystem";
            }
        }

        /// <summary>
        /// Encrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-encrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Encrypted
        {
            get;
            set;
        }

        /// <summary>
        /// FileSystemTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-filesystemtags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ElasticFileSystemTag
        /// </summary>
        public List<ElasticFileSystemTag> FileSystemTags
        {
            get;
            set;
        }

        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId
        {
            get;
            set;
        }

        /// <summary>
        /// PerformanceMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-efs-filesystem-performancemode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PerformanceMode
        {
            get;
            set;
        }

        /// <summary>
        /// ProvisionedThroughputInMibps
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-elasticfilesystem-filesystem-provisionedthroughputinmibps
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic ProvisionedThroughputInMibps
        {
            get;
            set;
        }

        /// <summary>
        /// ThroughputMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-filesystem.html#cfn-elasticfilesystem-filesystem-throughputmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ThroughputMode
        {
            get;
            set;
        }
    }

    namespace FileSystemTypes
    {
        public class ElasticFileSystemTag
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-filesystemtags.html#cfn-efs-filesystem-filesystemtags-key
            /// Required: True
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-filesystemtags.html#cfn-efs-filesystem-filesystemtags-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }
        }
    }
}