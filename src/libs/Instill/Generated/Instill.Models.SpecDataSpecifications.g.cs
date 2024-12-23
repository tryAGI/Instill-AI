
#nullable enable

namespace Instill
{
    /// <summary>
    /// Data specifications.<br/>
    /// The key represents the task, and the value is the corresponding data_specification.<br/>
    /// Note: This field will be renamed to task_specifications in the future.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class SpecDataSpecifications
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}