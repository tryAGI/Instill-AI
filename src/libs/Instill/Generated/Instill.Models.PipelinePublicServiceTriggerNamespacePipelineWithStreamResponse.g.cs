
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse
    {
        /// <summary>
        /// TriggerNamespacePipelineWithStreamResponse contains the pipeline execution results, i.e.,<br/>
        /// the multiple model inference outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::Instill.TriggerNamespacePipelineWithStreamResponse? Result { get; set; }

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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Instill.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Instill.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse),
                jsonSerializerContext) as global::Instill.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Instill.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Instill.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}