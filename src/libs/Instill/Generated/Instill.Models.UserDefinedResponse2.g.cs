
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserDefinedResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("greeting")]
        public string? Greeting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDefinedResponse2" /> class.
        /// </summary>
        /// <param name="greeting"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserDefinedResponse2(
            string? greeting)
        {
            this.Greeting = greeting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDefinedResponse2" /> class.
        /// </summary>
        public UserDefinedResponse2()
        {
        }
    }
}