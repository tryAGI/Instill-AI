
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContext(
            global::System.Collections.Generic.IList<string>? tableUids)
        {
            this.TableUids = tableUids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContext" /> class.
        /// </summary>
        public ChatContext()
        {
        }
    }
}