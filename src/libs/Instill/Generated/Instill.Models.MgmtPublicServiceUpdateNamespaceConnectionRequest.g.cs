
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MgmtPublicServiceUpdateNamespaceConnectionRequest
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Field 3: Human-readable display name for UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// When display_name changes, a new slug is generated and old slugs are stored<br/>
        /// here.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Field 6: Optional description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Field 7: Creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Field 8: Last update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Field 9: ID of the namespace owning the connection.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaceId")]
        public string? NamespaceId { get; set; }

        /// <summary>
        /// Field 10: Integration ID. It determines for which type of components can<br/>
        /// reference this connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// Field 11: Integration title. This helps the console display the results<br/>
        /// grouped by integration ID without needing an extra call to fetch title by<br/>
        /// integration ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationTitle")]
        public string? IntegrationTitle { get; set; }

        /// <summary>
        /// Field 12: Connection method. It references the setup schema provided by the<br/>
        /// integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.MgmtV1betaConnectionMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.MgmtV1betaConnectionMethod Method { get; set; }

        /// <summary>
        /// Field 13: Connection details. This field is required on creation, optional<br/>
        /// on view. When viewing the connection details, the setup values will be<br/>
        /// redacted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Setup { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.MgmtV1betaViewJsonConverter))]
        public global::Instill.MgmtV1betaView? View { get; set; }

        /// <summary>
        /// Field 15: A list of scopes that identify the resources that the connection<br/>
        /// will be able to access on the user's behalf. This is typically passed on<br/>
        /// creation when the setup has been generated through an OAuth flow with a<br/>
        /// limited set of scopes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Field 16: When the connection method is METHOD_OAUTH, the access token<br/>
        /// might come with some extra information that might vary across vendors. This<br/>
        /// information is passed as connection metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oAuthAccessDetails")]
        public object? OAuthAccessDetails { get; set; }

        /// <summary>
        /// Field 17: When the connection method is METHOD_OAUTH, this field will hold<br/>
        /// the identity (e.g., email, username) with which the access token has been<br/>
        /// generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        public string? Identity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MgmtPublicServiceUpdateNamespaceConnectionRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="slug"></param>
        /// <param name="aliases">
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// When display_name changes, a new slug is generated and old slugs are stored<br/>
        /// here.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Field 6: Optional description.
        /// </param>
        /// <param name="createTime">
        /// Field 7: Creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Field 8: Last update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="namespaceId">
        /// Field 9: ID of the namespace owning the connection.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="integrationId">
        /// Field 10: Integration ID. It determines for which type of components can<br/>
        /// reference this connection.
        /// </param>
        /// <param name="integrationTitle">
        /// Field 11: Integration title. This helps the console display the results<br/>
        /// grouped by integration ID without needing an extra call to fetch title by<br/>
        /// integration ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="method">
        /// Field 12: Connection method. It references the setup schema provided by the<br/>
        /// integration.
        /// </param>
        /// <param name="setup">
        /// Field 13: Connection details. This field is required on creation, optional<br/>
        /// on view. When viewing the connection details, the setup values will be<br/>
        /// redacted.
        /// </param>
        /// <param name="view">
        /// Included only in responses
        /// </param>
        /// <param name="scopes">
        /// Field 15: A list of scopes that identify the resources that the connection<br/>
        /// will be able to access on the user's behalf. This is typically passed on<br/>
        /// creation when the setup has been generated through an OAuth flow with a<br/>
        /// limited set of scopes.
        /// </param>
        /// <param name="oAuthAccessDetails">
        /// Field 16: When the connection method is METHOD_OAUTH, the access token<br/>
        /// might come with some extra information that might vary across vendors. This<br/>
        /// information is passed as connection metadata.
        /// </param>
        /// <param name="identity">
        /// Field 17: When the connection method is METHOD_OAUTH, this field will hold<br/>
        /// the identity (e.g., email, username) with which the access token has been<br/>
        /// generated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MgmtPublicServiceUpdateNamespaceConnectionRequest(
            string displayName,
            string integrationId,
            global::Instill.MgmtV1betaConnectionMethod method,
            object setup,
            string? id,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? namespaceId,
            string? integrationTitle,
            global::Instill.MgmtV1betaView? view,
            global::System.Collections.Generic.IList<string>? scopes,
            object? oAuthAccessDetails,
            string? identity)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.Method = method;
            this.Setup = setup ?? throw new global::System.ArgumentNullException(nameof(setup));
            this.Id = id;
            this.Slug = slug;
            this.Aliases = aliases;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.NamespaceId = namespaceId;
            this.IntegrationTitle = integrationTitle;
            this.View = view;
            this.Scopes = scopes;
            this.OAuthAccessDetails = oAuthAccessDetails;
            this.Identity = identity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MgmtPublicServiceUpdateNamespaceConnectionRequest" /> class.
        /// </summary>
        public MgmtPublicServiceUpdateNamespaceConnectionRequest()
        {
        }
    }
}