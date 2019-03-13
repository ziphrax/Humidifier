namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;
    using MethodTypes;

    public class Method : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ApiGateway::Method";
            }
        }

        /// <summary>
        /// ApiKeyRequired
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-apikeyrequired
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ApiKeyRequired
        {
            get;
            set;
        }

        /// <summary>
        /// AuthorizationScopes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-authorizationscopes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AuthorizationScopes
        {
            get;
            set;
        }

        /// <summary>
        /// AuthorizationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-authorizationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizationType
        {
            get;
            set;
        }

        /// <summary>
        /// AuthorizerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-authorizerid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizerId
        {
            get;
            set;
        }

        /// <summary>
        /// HttpMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-httpmethod
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HttpMethod
        {
            get;
            set;
        }

        /// <summary>
        /// Integration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-integration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Integration
        /// </summary>
        public Integration Integration
        {
            get;
            set;
        }

        /// <summary>
        /// MethodResponses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-methodresponses
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MethodResponse
        /// </summary>
        public List<MethodResponse> MethodResponses
        {
            get;
            set;
        }

        /// <summary>
        /// OperationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-operationname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OperationName
        {
            get;
            set;
        }

        /// <summary>
        /// RequestModels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-requestmodels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> RequestModels
        {
            get;
            set;
        }

        /// <summary>
        /// RequestParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-requestparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: Boolean
        /// </summary>
        public Dictionary<string, bool> RequestParameters
        {
            get;
            set;
        }

        /// <summary>
        /// RequestValidatorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-requestvalidatorid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RequestValidatorId
        {
            get;
            set;
        }

        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-resourceid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceId
        {
            get;
            set;
        }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-restapiid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RestApiId
        {
            get;
            set;
        }
    }

    namespace MethodTypes
    {
        public class MethodResponse
        {
            /// <summary>
            /// ResponseModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-methodresponse.html#cfn-apigateway-method-methodresponse-responsemodels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ResponseModels
            {
                get;
                set;
            }

            /// <summary>
            /// ResponseParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-methodresponse.html#cfn-apigateway-method-methodresponse-responseparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: Boolean
            /// </summary>
            public Dictionary<string, bool> ResponseParameters
            {
                get;
                set;
            }

            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-methodresponse.html#cfn-apigateway-method-methodresponse-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusCode
            {
                get;
                set;
            }
        }

        public class Integration
        {
            /// <summary>
            /// CacheKeyParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-cachekeyparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CacheKeyParameters
            {
                get;
                set;
            }

            /// <summary>
            /// CacheNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-cachenamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CacheNamespace
            {
                get;
                set;
            }

            /// <summary>
            /// ConnectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-connectionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectionId
            {
                get;
                set;
            }

            /// <summary>
            /// ConnectionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-connectiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectionType
            {
                get;
                set;
            }

            /// <summary>
            /// ContentHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-contenthandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentHandling
            {
                get;
                set;
            }

            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-credentials
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Credentials
            {
                get;
                set;
            }

            /// <summary>
            /// IntegrationHttpMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-integrationhttpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IntegrationHttpMethod
            {
                get;
                set;
            }

            /// <summary>
            /// IntegrationResponses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-integrationresponses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntegrationResponse
            /// </summary>
            public List<IntegrationResponse> IntegrationResponses
            {
                get;
                set;
            }

            /// <summary>
            /// PassthroughBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-passthroughbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PassthroughBehavior
            {
                get;
                set;
            }

            /// <summary>
            /// RequestParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-requestparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> RequestParameters
            {
                get;
                set;
            }

            /// <summary>
            /// RequestTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-requesttemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> RequestTemplates
            {
                get;
                set;
            }

            /// <summary>
            /// TimeoutInMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-timeoutinmillis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutInMillis
            {
                get;
                set;
            }

            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type
            {
                get;
                set;
            }

            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Uri
            {
                get;
                set;
            }
        }

        public class IntegrationResponse
        {
            /// <summary>
            /// ContentHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration-integrationresponse.html#cfn-apigateway-method-integrationresponse-contenthandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentHandling
            {
                get;
                set;
            }

            /// <summary>
            /// ResponseParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration-integrationresponse.html#cfn-apigateway-method-integration-integrationresponse-responseparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ResponseParameters
            {
                get;
                set;
            }

            /// <summary>
            /// ResponseTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration-integrationresponse.html#cfn-apigateway-method-integration-integrationresponse-responsetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ResponseTemplates
            {
                get;
                set;
            }

            /// <summary>
            /// SelectionPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration-integrationresponse.html#cfn-apigateway-method-integration-integrationresponse-selectionpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectionPattern
            {
                get;
                set;
            }

            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration-integrationresponse.html#cfn-apigateway-method-integration-integrationresponse-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusCode
            {
                get;
                set;
            }
        }
    }
}