
#nullable enable

namespace Instill
{
    /// <summary>
    /// Represents a table.
    /// </summary>
    public sealed partial class ChatContextTable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUids")]
        public global::System.Collections.Generic.IList<string>? FileUids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContextTable" /> class.
        /// </summary>
        /// <param name="tableUid"></param>
        /// <param name="fileUids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContextTable(
            string tableUid,
            global::System.Collections.Generic.IList<string>? fileUids)
        {
            this.TableUid = tableUid ?? throw new global::System.ArgumentNullException(nameof(tableUid));
            this.FileUids = fileUids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContextTable" /> class.
        /// </summary>
        public ChatContextTable()
        {
        }
    }
}