
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateObjectResponse contains the updated object.
    /// </summary>
    public sealed partial class UpdateObjectResponse
    {
        /// <summary>
        /// The updated object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public global::Instill.Object? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObjectResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The updated object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObjectResponse(
            global::Instill.Object? @object)
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