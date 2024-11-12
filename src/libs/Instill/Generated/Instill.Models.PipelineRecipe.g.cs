
#nullable enable

namespace Instill
{
    /// <summary>
    /// Recipe describes the components of a Pipeline and how they are connected.
    /// </summary>
    public sealed partial class PipelineRecipe
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRecipe" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelineRecipe(
 )
        {
        }
    }
}