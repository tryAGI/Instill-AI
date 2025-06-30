
#nullable enable

namespace Instill
{
    /// <summary>
    /// FileOption represents a file option.
    /// </summary>
    public sealed partial class FileOption
    {
        /// <summary>
        /// The UID of the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUid")]
        public string? FileUid { get; set; }

        /// <summary>
        /// The name of the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The file content type.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The file summary.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileOption" /> class.
        /// </summary>
        /// <param name="fileUid">
        /// The UID of the file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// The name of the file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// The file content type.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="summary">
        /// The file summary.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileOption(
            string? fileUid,
            string? name,
            string? type,
            string? summary)
        {
            this.FileUid = fileUid;
            this.Name = name;
            this.Type = type;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileOption" /> class.
        /// </summary>
        public FileOption()
        {
        }
    }
}