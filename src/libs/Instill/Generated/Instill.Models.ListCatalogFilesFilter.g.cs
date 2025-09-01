
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListCatalogFilesFilter contains a set of properties to filter a catalog file<br/>
    /// list by.
    /// </summary>
    public sealed partial class ListCatalogFilesFilter
    {
        /// <summary>
        /// File UIDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUids")]
        public global::System.Collections.Generic.IList<string>? FileUids { get; set; }

        /// <summary>
        /// Processing status of the files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileProcessStatusJsonConverter))]
        public global::Instill.FileProcessStatus? ProcessStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogFilesFilter" /> class.
        /// </summary>
        /// <param name="fileUids">
        /// File UIDs.
        /// </param>
        /// <param name="processStatus">
        /// Processing status of the files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCatalogFilesFilter(
            global::System.Collections.Generic.IList<string>? fileUids,
            global::Instill.FileProcessStatus? processStatus)
        {
            this.FileUids = fileUids;
            this.ProcessStatus = processStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogFilesFilter" /> class.
        /// </summary>
        public ListCatalogFilesFilter()
        {
        }
    }
}