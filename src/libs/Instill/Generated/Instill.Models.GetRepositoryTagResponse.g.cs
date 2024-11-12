
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetRepositoryTagResponse contains the created tag.
    /// </summary>
    public sealed partial class GetRepositoryTagResponse
    {
        /// <summary>
        /// The created tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public global::Instill.RepositoryTag? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepositoryTagResponse" /> class.
        /// </summary>
        /// <param name="tag">
        /// The created tag.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetRepositoryTagResponse(
            global::Instill.RepositoryTag? tag)
        {
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepositoryTagResponse" /> class.
        /// </summary>
        public GetRepositoryTagResponse()
        {
        }
    }
}