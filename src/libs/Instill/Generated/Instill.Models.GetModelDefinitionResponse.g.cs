
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetModelDefinitionResponse contains the requested model definition.
    /// </summary>
    public sealed partial class GetModelDefinitionResponse
    {
        /// <summary>
        /// The model definition resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelDefinition")]
        public global::Instill.ModelDefinition? ModelDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelDefinitionResponse" /> class.
        /// </summary>
        /// <param name="modelDefinition">
        /// The model definition resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelDefinitionResponse(
            global::Instill.ModelDefinition? modelDefinition)
        {
            this.ModelDefinition = modelDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelDefinitionResponse" /> class.
        /// </summary>
        public GetModelDefinitionResponse()
        {
        }
    }
}