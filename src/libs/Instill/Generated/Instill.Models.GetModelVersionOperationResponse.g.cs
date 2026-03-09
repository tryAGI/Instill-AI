
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetModelVersionOperationResponse represents a response to query a<br/>
    /// long-running operation.
    /// </summary>
    public sealed partial class GetModelVersionOperationResponse
    {
        /// <summary>
        /// The long-running operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public global::Instill.LongrunningOperation? Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelVersionOperationResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// The long-running operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelVersionOperationResponse(
            global::Instill.LongrunningOperation? operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelVersionOperationResponse" /> class.
        /// </summary>
        public GetModelVersionOperationResponse()
        {
        }
    }
}