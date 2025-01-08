
#nullable enable

namespace Instill
{
    /// <summary>
    /// ImageCell represents a cell with a url of an image resource.
    /// </summary>
    public sealed partial class ImageCell
    {
        /// <summary>
        /// The URL of the image resource.
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
        /// Initializes a new instance of the <see cref="ImageCell" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the image resource.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImageCell(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCell" /> class.
        /// </summary>
        public ImageCell()
        {
        }
    }
}