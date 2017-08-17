namespace Humidifier.EFS
{
    using System.Collections.Generic;
    using FileSystemPropertyTypes;

    public class FileSystem : IResource
    {
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
    }

    namespace FileSystemPropertyTypes
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