
#nullable enable

namespace Instill
{
    /// <summary>
    /// Each key in the `traces` object is a component ID. The value is a Trace<br/>
    /// object containing the execution details.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class TriggerMetadataTraces
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerMetadataTraces" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TriggerMetadataTraces(
 )
        {
        }
    }
}