
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchSourceFilesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFiles")]
        public global::System.Collections.Generic.IList<global::Instill.SourceFile>? SourceFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSourceFilesResponse" /> class.
        /// </summary>
        /// <param name="sourceFiles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchSourceFilesResponse(
            global::System.Collections.Generic.IList<global::Instill.SourceFile>? sourceFiles)
        {
            this.SourceFiles = sourceFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSourceFilesResponse" /> class.
        /// </summary>
        public SearchSourceFilesResponse()
        {
        }
    }
}