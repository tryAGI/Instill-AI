
#nullable enable

namespace Instill
{
    /// <summary>
    /// AudioCell represents a cell with a url of an audio resource.
    /// </summary>
    public sealed partial class AudioCell
    {
        /// <summary>
        /// The URL of the audio resource.
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
        /// Initializes a new instance of the <see cref="AudioCell" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the audio resource.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AudioCell(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioCell" /> class.
        /// </summary>
        public AudioCell()
        {
        }
    }
}