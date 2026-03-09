
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetObjectResponse contains the requested object.
    /// </summary>
    public sealed partial class GetObjectResponse
    {
        /// <summary>
        /// The requested object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public global::Instill.Object? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The requested object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetObjectResponse(
            global::Instill.Object? @object)
        {
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectResponse" /> class.
        /// </summary>
        public GetObjectResponse()
        {
        }
    }
}