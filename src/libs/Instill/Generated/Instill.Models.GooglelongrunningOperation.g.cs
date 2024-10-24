
#nullable enable

namespace Instill
{
    /// <summary>
    /// This resource represents a long-running operation that is the result of a<br/>
    /// network API call.
    /// </summary>
    public sealed partial class GooglelongrunningOperation
    {
        /// <summary>
        /// The server-assigned name, which is only unique within the same service that<br/>
        /// originally returns it. If you use the default HTTP mapping, the<br/>
        /// `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation.  It typically<br/>
        /// contains progress information and common metadata such as create time.<br/>
        /// Some services might not provide such metadata.  Any method that returns a<br/>
        /// long-running operation should document the metadata type, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Instill.ProtobufAny? Metadata { get; set; }

        /// <summary>
        /// If the value is `false`, it means the operation is still in progress.<br/>
        /// If `true`, the operation is completed, and either `error` or `response` is<br/>
        /// available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        public bool? Done { get; set; }

        /// <summary>
        /// The error result of the operation in case of failure or cancellation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Instill.GooglerpcStatus? Error { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success.  If the original<br/>
        /// method returns no data on success, such as `Delete`, the response is<br/>
        /// `google.protobuf.Empty`.  If the original method is standard<br/>
        /// `Get`/`Create`/`Update`, the response should be the resource.  For other<br/>
        /// methods, the response should have the type `XxxResponse`, where `Xxx`<br/>
        /// is the original method name.  For example, if the original method name<br/>
        /// is `TakeSnapshot()`, the inferred response type is<br/>
        /// `TakeSnapshotResponse`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::Instill.ProtobufAny? Response { get; set; }

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
        public static global::Instill.GooglelongrunningOperation? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Instill.GooglelongrunningOperation),
                jsonSerializerContext) as global::Instill.GooglelongrunningOperation;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Instill.GooglelongrunningOperation? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Instill.GooglelongrunningOperation>(
                json,
                jsonSerializerOptions);
        }

    }
}