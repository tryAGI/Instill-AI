
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateFileResponse represents a response for updating a file.
    /// </summary>
    public sealed partial class UpdateFileResponse
    {
        /// <summary>
        /// Updated file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::Instill.File? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFileResponse" /> class.
        /// </summary>
        /// <param name="file">
        /// Updated file.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFileResponse(
            global::Instill.File? file)
        {
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFileResponse" /> class.
        /// </summary>
        public UpdateFileResponse()
        {
        }
    }
}