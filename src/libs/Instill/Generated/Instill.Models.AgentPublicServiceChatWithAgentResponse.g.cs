
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPublicServiceChatWithAgentResponse
    {
        /// <summary>
        /// ChatWithAgentResponse contains the chatbot response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::Instill.ChatWithAgentResponse? Result { get; set; }

        /// <summary>
        /// The `Status` type defines a logical error model that is suitable for<br/>
        /// different programming environments, including REST APIs and RPC APIs. It is<br/>
        /// used by [gRPC](https://github.com/grpc). Each `Status` message contains<br/>
        /// three pieces of data: error code, error message, and error details.<br/>
        /// You can find out more about this error model and how to work with it in the<br/>
        /// [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Instill.RpcStatus? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPublicServiceChatWithAgentResponse" /> class.
        /// </summary>
        /// <param name="result">
        /// ChatWithAgentResponse contains the chatbot response.
        /// </param>
        /// <param name="error">
        /// The `Status` type defines a logical error model that is suitable for<br/>
        /// different programming environments, including REST APIs and RPC APIs. It is<br/>
        /// used by [gRPC](https://github.com/grpc). Each `Status` message contains<br/>
        /// three pieces of data: error code, error message, and error details.<br/>
        /// You can find out more about this error model and how to work with it in the<br/>
        /// [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPublicServiceChatWithAgentResponse(
            global::Instill.ChatWithAgentResponse? result,
            global::Instill.RpcStatus? error)
        {
            this.Result = result;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPublicServiceChatWithAgentResponse" /> class.
        /// </summary>
        public AgentPublicServiceChatWithAgentResponse()
        {
        }
    }
}