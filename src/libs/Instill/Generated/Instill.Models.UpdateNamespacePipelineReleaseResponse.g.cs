
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateNamespacePipelineReleaseResponse contains the updated pipeline release.
    /// </summary>
    public sealed partial class UpdateNamespacePipelineReleaseResponse
    {
        /// <summary>
        /// The updated pipeline release resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        public global::Instill.PipelineRelease? Release { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        /// <param name="release">
        /// The updated pipeline release resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateNamespacePipelineReleaseResponse(
            global::Instill.PipelineRelease? release)
        {
            this.Release = release;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        public UpdateNamespacePipelineReleaseResponse()
        {
        }
    }
}