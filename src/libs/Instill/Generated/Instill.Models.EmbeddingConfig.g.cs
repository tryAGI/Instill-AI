
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelFamily")]
        public string? ModelFamily { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensionality")]
        public long? Dimensionality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingConfig" /> class.
        /// </summary>
        /// <param name="modelFamily"></param>
        /// <param name="dimensionality"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingConfig(
            string? modelFamily,
            long? dimensionality)
        {
            this.ModelFamily = modelFamily;
            this.Dimensionality = dimensionality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingConfig" /> class.
        /// </summary>
        public EmbeddingConfig()
        {
        }
    }
}