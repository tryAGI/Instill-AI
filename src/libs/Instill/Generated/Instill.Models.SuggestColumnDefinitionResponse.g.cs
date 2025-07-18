
#nullable enable

namespace Instill
{
    /// <summary>
    /// SuggestColumnDefinitionResponse represents a response to a request to suggest a column definition.
    /// </summary>
    public sealed partial class SuggestColumnDefinitionResponse
    {
        /// <summary>
        /// Whether the suggestion is successful.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// The suggested column definition.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnDefinition")]
        public global::Instill.ColumnDefinition? ColumnDefinition { get; set; }

        /// <summary>
        /// The error message of the suggestion.<br/>
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
        /// Initializes a new instance of the <see cref="SuggestColumnDefinitionResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the suggestion is successful.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="columnDefinition">
        /// The suggested column definition.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="errorMessage">
        /// The error message of the suggestion.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuggestColumnDefinitionResponse(
            bool? success,
            global::Instill.ColumnDefinition? columnDefinition,
            string? errorMessage)
        {
            this.Success = success;
            this.ColumnDefinition = columnDefinition;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestColumnDefinitionResponse" /> class.
        /// </summary>
        public SuggestColumnDefinitionResponse()
        {
        }
    }
}