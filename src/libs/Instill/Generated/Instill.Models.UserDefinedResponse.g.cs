
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserDefinedResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("greeting")]
        public string? Greeting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numX2")]
        public string? NumX2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDefinedResponse" /> class.
        /// </summary>
        /// <param name="greeting"></param>
        /// <param name="numX2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserDefinedResponse(
            string? greeting,
            string? numX2)
        {
            this.Greeting = greeting;
            this.NumX2 = numX2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDefinedResponse" /> class.
        /// </summary>
        public UserDefinedResponse()
        {
        }
    }
}