
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChunkResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk")]
        public global::Instill.Chunk? Chunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChunkResponse" /> class.
        /// </summary>
        /// <param name="chunk">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChunkResponse(
            global::Instill.Chunk? chunk)
        {
            this.Chunk = chunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChunkResponse" /> class.
        /// </summary>
        public UpdateChunkResponse()
        {
        }
    }
}