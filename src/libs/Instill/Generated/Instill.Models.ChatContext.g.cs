
#nullable enable

namespace Instill
{
    /// <summary>
    /// The context for the message.
    /// </summary>
    public sealed partial class ChatContext
    {
        /// <summary>
        /// The table uids to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableUids")]
        public global::System.Collections.Generic.IList<string>? TableUids { get; set; }

        /// <summary>
        /// The folders to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folders")]
        public global::System.Collections.Generic.IList<global::Instill.ChatContextFolder>? Folders { get; set; }

        /// <summary>
        /// The catalogs to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogs")]
        public global::System.Collections.Generic.IList<global::Instill.ChatContextCatalog>? Catalogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContext" /> class.
        /// </summary>
        /// <param name="tableUids">
        /// The table uids to include in the context.
        /// </param>
        /// <param name="folders">
        /// The folders to include in the context.
        /// </param>
        /// <param name="catalogs">
        /// The catalogs to include in the context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContext(
            global::System.Collections.Generic.IList<string>? tableUids,
            global::System.Collections.Generic.IList<global::Instill.ChatContextFolder>? folders,
            global::System.Collections.Generic.IList<global::Instill.ChatContextCatalog>? catalogs)
        {
            this.TableUids = tableUids;
            this.Folders = folders;
            this.Catalogs = catalogs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContext" /> class.
        /// </summary>
        public ChatContext()
        {
        }
    }
}