
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetAppsResponse represents a response for getting all apps from users.
    /// </summary>
    public sealed partial class ListAppsResponse
    {
        /// <summary>
        /// The apps container.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::System.Collections.Generic.IList<global::Instill.App>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAppsResponse" /> class.
        /// </summary>
        /// <param name="apps">
        /// The apps container.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListAppsResponse(
            global::System.Collections.Generic.IList<global::Instill.App>? apps)
        {
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAppsResponse" /> class.
        /// </summary>
        public ListAppsResponse()
        {
        }
    }
}