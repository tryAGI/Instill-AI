
#nullable enable

namespace Instill
{
    /// <summary>
    /// EnhanceColumnDefinitionInstructionsResponse represents a response to a request to enhance the instruction of a column definition.
    /// </summary>
    public sealed partial class EnhanceColumnDefinitionInstructionsResponse
    {
        /// <summary>
        /// Whether the enhancement is successful.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// The enhanced instructions.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The error message of the enhancement.<br/>
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
        /// Initializes a new instance of the <see cref="EnhanceColumnDefinitionInstructionsResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the enhancement is successful.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="instructions">
        /// The enhanced instructions.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="errorMessage">
        /// The error message of the enhancement.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnhanceColumnDefinitionInstructionsResponse(
            bool? success,
            string? instructions,
            string? errorMessage)
        {
            this.Success = success;
            this.Instructions = instructions;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhanceColumnDefinitionInstructionsResponse" /> class.
        /// </summary>
        public EnhanceColumnDefinitionInstructionsResponse()
        {
        }
    }
}