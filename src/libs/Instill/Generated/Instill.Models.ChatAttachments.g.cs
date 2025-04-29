
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatAttachments
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUrls")]
        public global::System.Collections.Generic.IList<string>? FileUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAttachments" /> class.
        /// </summary>
        /// <param name="fileUrls">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatAttachments(
            global::System.Collections.Generic.IList<string>? fileUrls)
        {
            this.FileUrls = fileUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAttachments" /> class.
        /// </summary>
        public ChatAttachments()
        {
        }
    }
}