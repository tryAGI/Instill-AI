
#nullable enable

namespace Instill
{
    /// <summary>
    /// Map of column UID to their definitions.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class GetColumnDefinitionsResponseColumnDefinitions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}