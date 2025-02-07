
#nullable enable

namespace Instill
{
    /// <summary>
    /// VideoCell represents a cell with a url of a video resource.
    /// </summary>
    public sealed partial class VideoCell
    {
        /// <summary>
        /// The URL of the video resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCell" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the video resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoCell(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCell" /> class.
        /// </summary>
        public VideoCell()
        {
        }
    }
}