
#nullable enable

namespace Instill
{
    /// <summary>
    /// ClonePipelineRequest represents a request to clone a pipeline owned<br/>
    /// by a user.
    /// </summary>
    public sealed partial class ClonePipelineBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Pipeline description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Pipeline sharing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        public global::Instill.Sharing? Sharing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonePipelineBody" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="description">
        /// Pipeline description.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClonePipelineBody(
            string target,
            string? description,
            global::Instill.Sharing? sharing)
        {
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Description = description;
            this.Sharing = sharing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonePipelineBody" /> class.
        /// </summary>
        public ClonePipelineBody()
        {
        }
    }
}