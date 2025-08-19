
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuestionAnsweringBody
    {
        /// <summary>
        /// Text prompt with the question.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        public string? Question { get; set; }

        /// <summary>
        /// Top K. Default value: 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// File UIDs. When this field is provided, the response will only use the<br/>
        /// specified files to build the answer. The UIDs must be UUID-formatted<br/>
        /// strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUids")]
        public global::System.Collections.Generic.IList<string>? FileUids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionAnsweringBody" /> class.
        /// </summary>
        /// <param name="question">
        /// Text prompt with the question.
        /// </param>
        /// <param name="topK">
        /// Top K. Default value: 5.
        /// </param>
        /// <param name="fileUids">
        /// File UIDs. When this field is provided, the response will only use the<br/>
        /// specified files to build the answer. The UIDs must be UUID-formatted<br/>
        /// strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuestionAnsweringBody(
            string? question,
            int? topK,
            global::System.Collections.Generic.IList<string>? fileUids)
        {
            this.Question = question;
            this.TopK = topK;
            this.FileUids = fileUids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionAnsweringBody" /> class.
        /// </summary>
        public QuestionAnsweringBody()
        {
        }
    }
}