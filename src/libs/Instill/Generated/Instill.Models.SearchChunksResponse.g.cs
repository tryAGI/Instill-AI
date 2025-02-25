
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchChunksResponse
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
        /// Initializes a new instance of the <see cref="SearchChunksResponse" /> class.
        /// </summary>
        /// <param name="chunks">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchChunksResponse(
            global::System.Collections.Generic.IList<global::Instill.Chunk>? chunks)
        {
            this.Chunks = chunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchChunksResponse" /> class.
        /// </summary>
        public SearchChunksResponse()
        {
        }
    }
}