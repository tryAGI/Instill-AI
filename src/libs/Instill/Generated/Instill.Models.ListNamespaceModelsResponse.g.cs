
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListNamespaceModelsResponse contains a list of models.
    /// </summary>
    public sealed partial class ListNamespaceModelsResponse
    {
        /// <summary>
        /// A list of model resources.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Instill.Model>? Models { get; set; }

        /// <summary>
        /// Next page token.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of models.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNamespaceModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// A list of model resources.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of models.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListNamespaceModelsResponse(
            global::System.Collections.Generic.IList<global::Instill.Model>? models,
            string? nextPageToken,
            int? totalSize)
        {
            this.Models = models;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNamespaceModelsResponse" /> class.
        /// </summary>
        public ListNamespaceModelsResponse()
        {
        }
    }
}