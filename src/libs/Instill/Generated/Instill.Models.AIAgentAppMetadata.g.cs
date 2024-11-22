
#nullable enable

namespace Instill
{
    /// <summary>
    /// AIAgentAppMetadata represents the metadata for the AI agent app.
    /// </summary>
    public sealed partial class AIAgentAppMetadata
    {
        /// <summary>
        /// The instructions for the AI agent app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The tools(pipelines) that the AI agent app can use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Instill.Tool>? Tools { get; set; }

        /// <summary>
        /// The catalog uids that the AI agent app can use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUids")]
        public global::System.Collections.Generic.IList<string>? CatalogUids { get; set; }

        /// <summary>
        /// The AI agent app top k.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkTopK")]
        public int? ChunkTopK { get; set; }

        /// <summary>
        /// The AI agent chunk weight.
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
        /// <param name="instructions">
        /// The instructions for the AI agent app.
        /// </param>
        /// <param name="tools">
        /// The tools(pipelines) that the AI agent app can use.
        /// </param>
        /// <param name="catalogUids">
        /// The catalog uids that the AI agent app can use.
        /// </param>
        /// <param name="chunkTopK">
        /// The AI agent app top k.
        /// </param>
        /// <param name="chunkWeight">
        /// The AI agent chunk weight.
        /// </param>
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