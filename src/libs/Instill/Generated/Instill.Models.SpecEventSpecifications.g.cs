
#nullable enable

namespace Instill
{
    /// <summary>
    /// Event specifications.<br/>
    /// The key represents the event, and the value is the corresponding event_specification.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class SpecEventSpecifications
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecEventSpecifications" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SpecEventSpecifications(
 )
        {
        }
    }
}