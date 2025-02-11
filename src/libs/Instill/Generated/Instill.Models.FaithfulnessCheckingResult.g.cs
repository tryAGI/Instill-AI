
#nullable enable

namespace Instill
{
    /// <summary>
    /// The faithfulness checking result for the cell.
    /// </summary>
    public sealed partial class FaithfulnessCheckingResult
    {
        /// <summary>
        /// The text of the faithfulness checking result.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// The confidence score for the faithfulness checking result.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidenceScore")]
        public double? ConfidenceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaithfulnessCheckingResult" /> class.
        /// </summary>
        /// <param name="result">
        /// The text of the faithfulness checking result.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="confidenceScore">
        /// The confidence score for the faithfulness checking result.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaithfulnessCheckingResult(
            string? result,
            double? confidenceScore)
        {
            this.Result = result;
            this.ConfidenceScore = confidenceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaithfulnessCheckingResult" /> class.
        /// </summary>
        public FaithfulnessCheckingResult()
        {
        }
    }
}