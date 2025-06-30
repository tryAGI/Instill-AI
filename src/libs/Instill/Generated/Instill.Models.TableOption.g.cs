
#nullable enable

namespace Instill
{
    /// <summary>
    /// TableOption represents a table option.
    /// </summary>
    public sealed partial class TableOption
    {
        /// <summary>
        /// The UID of the table.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableUid")]
        public string? TableUid { get; set; }

        /// <summary>
        /// The table title.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The table description.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The UIDs of the files in the table.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileOptions")]
        public global::System.Collections.Generic.IList<global::Instill.FileOption>? FileOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableOption" /> class.
        /// </summary>
        /// <param name="tableUid">
        /// The UID of the table.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// The table title.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// The table description.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="fileOptions">
        /// The UIDs of the files in the table.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableOption(
            string? tableUid,
            string? title,
            string? description,
            global::System.Collections.Generic.IList<global::Instill.FileOption>? fileOptions)
        {
            this.TableUid = tableUid;
            this.Title = title;
            this.Description = description;
            this.FileOptions = fileOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableOption" /> class.
        /// </summary>
        public TableOption()
        {
        }
    }
}