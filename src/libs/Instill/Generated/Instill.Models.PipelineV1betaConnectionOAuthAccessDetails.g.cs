
#nullable enable

namespace Instill
{
    /// <summary>
    /// Field 16: When the connection method is METHOD_OAUTH, the access token<br/>
    /// might come with some extra information that might vary across vendors. This<br/>
    /// information is passed as connection metadata.
    /// </summary>
    public sealed partial class PipelineV1betaConnectionOAuthAccessDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}