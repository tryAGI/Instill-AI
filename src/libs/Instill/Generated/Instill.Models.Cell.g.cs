
#nullable enable

namespace Instill
{
    /// <summary>
    /// Cell represents a cell in a table.
    /// </summary>
    public sealed partial class Cell
    {
        /// <summary>
        /// The unique identifier of the cell.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// The unique identifier of the column this cell belongs to.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnUid")]
        public string? ColumnUid { get; set; }

        /// <summary>
        /// The row that this cell belongs to.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowUid")]
        public string? RowUid { get; set; }

        /// <summary>
        /// The timestamp when the cell was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The type of the cell's value.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.TypeJsonConverter))]
        public global::Instill.Type? Type { get; set; }

        /// <summary>
        /// The value of the cell as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stringValue")]
        public global::Instill.StringCell? StringValue { get; set; }

        /// <summary>
        /// The value of the cell as a number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberValue")]
        public global::Instill.NumberCell? NumberValue { get; set; }

        /// <summary>
        /// The value of the cell as a boolean.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("booleanValue")]
        public global::Instill.BooleanCell? BooleanValue { get; set; }

        /// <summary>
        /// The value of the cell as a file resource. This can represent various file types<br/>
        /// such as images, documents, audio, or other binary data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileValue")]
        public global::Instill.FileCell? FileValue { get; set; }

        /// <summary>
        /// The value of the cell as a document resource. The document resource is a<br/>
        /// file resource that is specifically designed for document types, such as<br/>
        /// TXT, Markdown, PDF, DOC, and PPT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentValue")]
        public global::Instill.DocumentCell? DocumentValue { get; set; }

        /// <summary>
        /// Additional metadata for the cell.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The status of the cell.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.CellStatusJsonConverter))]
        public global::Instill.CellStatus? Status { get; set; }

        /// <summary>
        /// The citations for the cell.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::Instill.Citation>? Citations { get; set; }

        /// <summary>
        /// The transparency of the cell.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transparency")]
        public global::Instill.Transparency? Transparency { get; set; }

        /// <summary>
        /// The lock state of the cell.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.LockStateJsonConverter))]
        public global::Instill.LockState? LockState { get; set; }

        /// <summary>
        /// The error message of the cell.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        /// <param name="uid">
        /// The unique identifier of the cell.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="columnUid">
        /// The unique identifier of the column this cell belongs to.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="rowUid">
        /// The row that this cell belongs to.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// The timestamp when the cell was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// The type of the cell's value.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="stringValue">
        /// The value of the cell as a string.
        /// </param>
        /// <param name="numberValue">
        /// The value of the cell as a number.
        /// </param>
        /// <param name="booleanValue">
        /// The value of the cell as a boolean.
        /// </param>
        /// <param name="fileValue">
        /// The value of the cell as a file resource. This can represent various file types<br/>
        /// such as images, documents, audio, or other binary data.
        /// </param>
        /// <param name="documentValue">
        /// The value of the cell as a document resource. The document resource is a<br/>
        /// file resource that is specifically designed for document types, such as<br/>
        /// TXT, Markdown, PDF, DOC, and PPT.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata for the cell.
        /// </param>
        /// <param name="status">
        /// The status of the cell.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="citations">
        /// The citations for the cell.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="transparency">
        /// The transparency of the cell.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lockState">
        /// The lock state of the cell.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="errorMessage">
        /// The error message of the cell.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Cell(
            string? uid,
            string? columnUid,
            string? rowUid,
            global::System.DateTime? updateTime,
            global::Instill.Type? type,
            global::Instill.StringCell? stringValue,
            global::Instill.NumberCell? numberValue,
            global::Instill.BooleanCell? booleanValue,
            global::Instill.FileCell? fileValue,
            global::Instill.DocumentCell? documentValue,
            object? metadata,
            global::Instill.CellStatus? status,
            global::System.Collections.Generic.IList<global::Instill.Citation>? citations,
            global::Instill.Transparency? transparency,
            global::Instill.LockState? lockState,
            string? errorMessage)
        {
            this.Uid = uid;
            this.ColumnUid = columnUid;
            this.RowUid = rowUid;
            this.UpdateTime = updateTime;
            this.Type = type;
            this.StringValue = stringValue;
            this.NumberValue = numberValue;
            this.BooleanValue = booleanValue;
            this.FileValue = fileValue;
            this.DocumentValue = documentValue;
            this.Metadata = metadata;
            this.Status = status;
            this.Citations = citations;
            this.Transparency = transparency;
            this.LockState = lockState;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        public Cell()
        {
        }
    }
}