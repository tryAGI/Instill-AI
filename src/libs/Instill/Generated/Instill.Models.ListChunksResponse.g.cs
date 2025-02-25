
#nullable enable

namespace Instill
{
    /// <summary>
    /// The ListChunksResponse message represents a response containing a list of chunks in the artifact system.
    /// </summary>
    public sealed partial class ListChunksResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        public global::System.Collections.Generic.IList<global::Instill.Chunk>? Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChunksResponse" /> class.
        /// </summary>
        /// <param name="chunks">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListChunksResponse(
            global::System.Collections.Generic.IList<global::Instill.Chunk>? chunks)
        {
            this.Chunks = chunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChunksResponse" /> class.
        /// </summary>
        public ListChunksResponse()
        {
        }
    }
}