
#nullable enable

namespace Instill
{
    /// <summary>
    /// ValidateNamespacePipelineRequest represents a request to validate a pipeline<br/>
    /// owned by a user.
    /// </summary>
    public sealed partial class ValidateNamespacePipelineBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateNamespacePipelineBody" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ValidateNamespacePipelineBody(
 )
        {
        }
    }
}