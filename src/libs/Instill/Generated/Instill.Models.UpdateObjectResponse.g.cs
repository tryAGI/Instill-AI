
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObjectResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public global::Instill.AIObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObjectResponse" /> class.
        /// </summary>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObjectResponse(
            global::Instill.AIObject? @object)
        {
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObjectResponse" /> class.
        /// </summary>
        public UpdateObjectResponse()
        {
        }
    }
}