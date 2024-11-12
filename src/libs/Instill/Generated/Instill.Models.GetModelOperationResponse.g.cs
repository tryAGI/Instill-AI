
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetModelOperationRequest represents a request to query a long-running<br/>
    /// operation.
    /// </summary>
    public sealed partial class GetModelOperationResponse
    {
        /// <summary>
        /// The long-running operation.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public global::Instill.LongrunningOperation? Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelOperationResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// The long-running operation.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetModelOperationResponse(
            global::Instill.LongrunningOperation? operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelOperationResponse" /> class.
        /// </summary>
        public GetModelOperationResponse()
        {
        }
    }
}