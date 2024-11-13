
#nullable enable

namespace Instill
{
    /// <summary>
    /// JSON schema describing the component event setup data.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class EventSpecificationSetupSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventSpecificationSetupSchema" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EventSpecificationSetupSchema(
 )
        {
        }
    }
}