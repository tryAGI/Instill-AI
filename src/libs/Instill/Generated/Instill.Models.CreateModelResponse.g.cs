
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateModelResponse contains the created model.
    /// </summary>
    public sealed partial class CreateModelResponse
    {
        /// <summary>
        /// The created model resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Instill.Model? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The created model resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelResponse(
            global::Instill.Model? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelResponse" /> class.
        /// </summary>
        public CreateModelResponse()
        {
        }
    }
}