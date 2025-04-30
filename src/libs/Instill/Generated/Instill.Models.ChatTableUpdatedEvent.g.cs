
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatTableUpdatedEvent
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableUid")]
        public string? TableUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public global::Instill.Table? Table { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnDefinitions")]
        public global::System.Collections.Generic.Dictionary<string, global::Instill.ColumnDefinition>? ColumnDefinitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTableUpdatedEvent" /> class.
        /// </summary>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="tableUid">
        /// Included only in responses
        /// </param>
        /// <param name="table">
        /// Included only in responses
        /// </param>
        /// <param name="columnDefinitions">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatTableUpdatedEvent(
            global::System.DateTime? createTime,
            string? tableUid,
            global::Instill.Table? table,
            global::System.Collections.Generic.Dictionary<string, global::Instill.ColumnDefinition>? columnDefinitions)
        {
            this.CreateTime = createTime;
            this.TableUid = tableUid;
            this.Table = table;
            this.ColumnDefinitions = columnDefinitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTableUpdatedEvent" /> class.
        /// </summary>
        public ChatTableUpdatedEvent()
        {
        }
    }
}