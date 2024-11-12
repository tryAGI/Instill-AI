
#nullable enable

namespace Instill
{
    /// <summary>
    /// Key-value object with console-related data such as the pipeline builder<br/>
    /// layout.
    /// </summary>
    public sealed partial class PipelineReleaseMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineReleaseMetadata" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelineReleaseMetadata(
 )
        {
        }
    }
}