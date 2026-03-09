
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetIntegrationResponse contains the requested integration.
    /// </summary>
    public sealed partial class PipelineV1betaGetIntegrationResponse
    {
        /// <summary>
        /// The requested integration.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        public global::Instill.PipelineV1betaIntegration? Integration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineV1betaGetIntegrationResponse" /> class.
        /// </summary>
        /// <param name="integration">
        /// The requested integration.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineV1betaGetIntegrationResponse(
            global::Instill.PipelineV1betaIntegration? integration)
        {
            this.Integration = integration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineV1betaGetIntegrationResponse" /> class.
        /// </summary>
        public PipelineV1betaGetIntegrationResponse()
        {
        }
    }
}