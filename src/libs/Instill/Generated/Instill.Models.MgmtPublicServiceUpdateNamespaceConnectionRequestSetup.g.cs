
#nullable enable

namespace Instill
{
    /// <summary>
    /// Field 13: Connection details. This field is required on creation, optional<br/>
    /// on view. When viewing the connection details, the setup values will be<br/>
    /// redacted.
    /// </summary>
    public sealed partial class MgmtPublicServiceUpdateNamespaceConnectionRequestSetup
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}