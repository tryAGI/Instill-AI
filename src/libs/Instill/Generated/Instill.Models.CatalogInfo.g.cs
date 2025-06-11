
#nullable enable

namespace Instill
{
    /// <summary>
    /// CatalogInfo contains the information about the catalog.
    /// </summary>
    public sealed partial class CatalogInfo
    {
        /// <summary>
        /// The number of files in the catalog.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileCount")]
        public int? FileCount { get; set; }

        /// <summary>
        /// The total size of all files in the catalog in bytes.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSizeBytes")]
        public string? TotalSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogInfo" /> class.
        /// </summary>
        /// <param name="fileCount">
        /// The number of files in the catalog.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSizeBytes">
        /// The total size of all files in the catalog in bytes.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CatalogInfo(
            int? fileCount,
            string? totalSizeBytes)
        {
            this.FileCount = fileCount;
            this.TotalSizeBytes = totalSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogInfo" /> class.
        /// </summary>
        public CatalogInfo()
        {
        }
    }
}