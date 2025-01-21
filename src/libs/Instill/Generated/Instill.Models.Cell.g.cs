
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
        public string? Type { get; set; }

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
        /// The value of the cell as a url of a file resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileValue")]
        public global::Instill.FileCell? FileValue { get; set; }

        /// <summary>
        /// The value of the cell as a url of a document resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentValue")]
        public global::Instill.DocumentCell? DocumentValue { get; set; }

        /// <summary>
        /// The value of the cell as a url of an image resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageValue")]
        public global::Instill.ImageCell? ImageValue { get; set; }

        /// <summary>
        /// The value of the cell as a url of a video resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoValue")]
        public global::Instill.VideoCell? VideoValue { get; set; }

        /// <summary>
        /// The value of the cell as a url of an audio resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioValue")]
        public global::Instill.AudioCell? AudioValue { get; set; }

        /// <summary>
        /// The value of the cell as a null cell.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nullValue")]
        public object? NullValue { get; set; }

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
        /// The value of the cell as a url of a file resource.
        /// </param>
        /// <param name="documentValue">
        /// The value of the cell as a url of a document resource.
        /// </param>
        /// <param name="imageValue">
        /// The value of the cell as a url of an image resource.
        /// </param>
        /// <param name="videoValue">
        /// The value of the cell as a url of a video resource.
        /// </param>
        /// <param name="audioValue">
        /// The value of the cell as a url of an audio resource.
        /// </param>
        /// <param name="nullValue">
        /// The value of the cell as a null cell.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata for the cell.
        /// </param>
        /// <param name="status">
        /// The status of the cell.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Cell(
            string? uid,
            string? columnUid,
            string? rowUid,
            global::System.DateTime? updateTime,
            string? type,
            global::Instill.StringCell? stringValue,
            global::Instill.NumberCell? numberValue,
            global::Instill.BooleanCell? booleanValue,
            global::Instill.FileCell? fileValue,
            global::Instill.DocumentCell? documentValue,
            global::Instill.ImageCell? imageValue,
            global::Instill.VideoCell? videoValue,
            global::Instill.AudioCell? audioValue,
            object? nullValue,
            object? metadata,
            global::Instill.CellStatus? status)
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
            this.ImageValue = imageValue;
            this.VideoValue = videoValue;
            this.AudioValue = audioValue;
            this.NullValue = nullValue;
            this.Metadata = metadata;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        public Cell()
        {
        }
    }
}