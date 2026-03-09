
#nullable enable

namespace Instill
{
    /// <summary>
    /// Field 7: The connection setup field definitions. Each integration will<br/>
    /// require different data to connect to the 3rd party app.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class PipelineV1betaIntegrationSetupSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}