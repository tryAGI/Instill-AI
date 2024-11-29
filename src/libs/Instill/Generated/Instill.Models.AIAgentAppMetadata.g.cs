
#nullable enable

namespace Instill
{
    /// <summary>
    /// AIAgentAppMetadata represents the metadata for the AI agent app.
    /// </summary>
    public sealed partial class AIAgentAppMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Instill.Tool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUids")]
        public global::System.Collections.Generic.IList<string>? CatalogUids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkTopK")]
        public int? ChunkTopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkWeight")]
        public float? ChunkWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIAgentAppMetadata" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="tools"></param>
        /// <param name="catalogUids"></param>
        /// <param name="chunkTopK"></param>
        /// <param name="chunkWeight"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AIAgentAppMetadata(
            string? instructions,
            global::System.Collections.Generic.IList<global::Instill.Tool>? tools,
            global::System.Collections.Generic.IList<string>? catalogUids,
            int? chunkTopK,
            float? chunkWeight)
        {
            this.Instructions = instructions;
            this.Tools = tools;
            this.CatalogUids = catalogUids;
            this.ChunkTopK = chunkTopK;
            this.ChunkWeight = chunkWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIAgentAppMetadata" /> class.
        /// </summary>
        public AIAgentAppMetadata()
        {
        }
    }
}