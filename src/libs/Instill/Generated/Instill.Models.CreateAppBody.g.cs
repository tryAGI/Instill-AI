
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateAppRequest represents a request to create a app.
    /// </summary>
    public sealed partial class CreateAppBody
    {
        /// <summary>
        /// The app id.<br/>
        /// the app id should be lowercase without any space or special character besides the hyphen,<br/>
        /// it can not start with number or hyphen, and should be less than 32 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The app description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The app tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.AppTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.AppType AppType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAssistantApp")]
        public global::Instill.AIAssistantAppMetadata? AiAssistantApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAgentApp")]
        public global::Instill.AIAgentAppMetadata? AiAgentApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppBody" /> class.
        /// </summary>
        /// <param name="id">
        /// The app id.<br/>
        /// the app id should be lowercase without any space or special character besides the hyphen,<br/>
        /// it can not start with number or hyphen, and should be less than 32 characters.
        /// </param>
        /// <param name="description">
        /// The app description.
        /// </param>
        /// <param name="tags">
        /// The app tags.
        /// </param>
        /// <param name="appType"></param>
        /// <param name="aiAssistantApp"></param>
        /// <param name="aiAgentApp"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateAppBody(
            string id,
            global::Instill.AppType appType,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::Instill.AIAssistantAppMetadata? aiAssistantApp,
            global::Instill.AIAgentAppMetadata? aiAgentApp)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AppType = appType;
            this.Description = description;
            this.Tags = tags;
            this.AiAssistantApp = aiAssistantApp;
            this.AiAgentApp = aiAgentApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppBody" /> class.
        /// </summary>
        public CreateAppBody()
        {
        }
    }
}