
#nullable enable

namespace Instill
{
    /// <summary>
    /// Custom metadata provided by the user during file upload.
    /// </summary>
    public sealed partial class FileExternalMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}