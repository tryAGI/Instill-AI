
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetIntegrationResponse contains the requested integration.
    /// </summary>
    public sealed partial class MgmtV1betaGetIntegrationResponse
    {
        /// <summary>
        /// The requested integration.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        public global::Instill.MgmtV1betaIntegration? Integration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MgmtV1betaGetIntegrationResponse" /> class.
        /// </summary>
        /// <param name="integration">
        /// The requested integration.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MgmtV1betaGetIntegrationResponse(
            global::Instill.MgmtV1betaIntegration? integration)
        {
            this.Integration = integration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MgmtV1betaGetIntegrationResponse" /> class.
        /// </summary>
        public MgmtV1betaGetIntegrationResponse()
        {
        }
    }
}