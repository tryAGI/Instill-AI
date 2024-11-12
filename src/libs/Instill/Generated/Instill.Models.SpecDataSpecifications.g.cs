
#nullable enable

namespace Instill
{
    /// <summary>
    /// Data specifications.<br/>
    /// The key represents the task, and the value is the corresponding data_specification.
    /// </summary>
    public sealed partial class SpecDataSpecifications
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecDataSpecifications" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SpecDataSpecifications(
 )
        {
        }
    }
}