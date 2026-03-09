
#nullable enable

namespace Instill
{
    /// <summary>
    /// Integration contains the parameters to create a connection between<br/>
    /// components and 3rd party apps.
    /// </summary>
    public sealed partial class MgmtV1betaIntegration
    {
        /// <summary>
        /// Field 1: Identifier of the integration, which references a component<br/>
        /// definition. Components with that definition ID will be able to use the<br/>
        /// connections produced by this integration.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Field 2: Title, reflects the app name.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Field 3: Short description of the integrated app.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Field 4: Integrated app vendor name.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendor")]
        public string? Vendor { get; set; }

        /// <summary>
        /// Field 5: Integration icon. This is a path that's relative to the root of<br/>
        /// the component implementation and that allows frontend applications to pull<br/>
        /// and locate the icons.<br/>
        /// See the `icon` field in the `ComponentDefinition` entity for more<br/>
        /// information.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Field 6: Reference to the vendor's documentation to expand the integration<br/>
        /// details.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("helpLink")]
        public global::Instill.MgmtV1betaIntegrationLink? HelpLink { get; set; }

        /// <summary>
        /// Field 7: The connection setup field definitions. Each integration will<br/>
        /// require different data to connect to the 3rd party app.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupSchema")]
        public object? SetupSchema { get; set; }

        /// <summary>
        /// Field 8: Configuration parameters required for the OAuth setup flow. This<br/>
        /// field will be present only if the integration supports OAuth 2.0.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oAuthConfig")]
        public global::Instill.MgmtV1betaIntegrationOAuthConfig? OAuthConfig { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.MgmtV1betaViewJsonConverter))]
        public global::Instill.MgmtV1betaView? View { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MgmtV1betaIntegration" /> class.
        /// </summary>
        /// <param name="id">
        /// Field 1: Identifier of the integration, which references a component<br/>
        /// definition. Components with that definition ID will be able to use the<br/>
        /// connections produced by this integration.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// Field 2: Title, reflects the app name.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Field 3: Short description of the integrated app.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="vendor">
        /// Field 4: Integrated app vendor name.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="icon">
        /// Field 5: Integration icon. This is a path that's relative to the root of<br/>
        /// the component implementation and that allows frontend applications to pull<br/>
        /// and locate the icons.<br/>
        /// See the `icon` field in the `ComponentDefinition` entity for more<br/>
        /// information.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="helpLink">
        /// Field 6: Reference to the vendor's documentation to expand the integration<br/>
        /// details.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="setupSchema">
        /// Field 7: The connection setup field definitions. Each integration will<br/>
        /// require different data to connect to the 3rd party app.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="oAuthConfig">
        /// Field 8: Configuration parameters required for the OAuth setup flow. This<br/>
        /// field will be present only if the integration supports OAuth 2.0.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="view">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MgmtV1betaIntegration(
            string? id,
            string? title,
            string? description,
            string? vendor,
            string? icon,
            global::Instill.MgmtV1betaIntegrationLink? helpLink,
            object? setupSchema,
            global::Instill.MgmtV1betaIntegrationOAuthConfig? oAuthConfig,
            global::Instill.MgmtV1betaView? view)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Vendor = vendor;
            this.Icon = icon;
            this.HelpLink = helpLink;
            this.SetupSchema = setupSchema;
            this.OAuthConfig = oAuthConfig;
            this.View = view;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MgmtV1betaIntegration" /> class.
        /// </summary>
        public MgmtV1betaIntegration()
        {
        }
    }
}