
#nullable enable

namespace Instill
{
    /// <summary>
    /// A collection of secrets. By default, if a pipeline references any secret<br/>
    /// (`${secret.&lt;id&gt;}`), its value is read from the namespace's secrets.<br/>
    /// This object provides a way to override these secret values: if one of its<br/>
    /// keys matches the ID of a reference secret, its value will be read from<br/>
    /// here instead of from the namespace secret collection.
    /// </summary>
    public sealed partial class TriggerDataSecret
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}