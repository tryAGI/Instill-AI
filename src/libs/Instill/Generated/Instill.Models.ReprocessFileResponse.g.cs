
#nullable enable

namespace Instill
{
    /// <summary>
    /// ReprocessFileResponse represents a response for reprocessing a file.
    /// </summary>
    public sealed partial class ReprocessFileResponse
    {
        /// <summary>
        /// The file being reprocessed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::Instill.File? File { get; set; }

        /// <summary>
        /// Status message.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReprocessFileResponse" /> class.
        /// </summary>
        /// <param name="file">
        /// The file being reprocessed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="message">
        /// Status message.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReprocessFileResponse(
            global::Instill.File? file,
            string? message)
        {
            this.File = file;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReprocessFileResponse" /> class.
        /// </summary>
        public ReprocessFileResponse()
        {
        }
    }
}