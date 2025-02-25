
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSourceFileResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFile")]
        public global::Instill.SourceFile? SourceFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSourceFileResponse" /> class.
        /// </summary>
        /// <param name="sourceFile">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSourceFileResponse(
            global::Instill.SourceFile? sourceFile)
        {
            this.SourceFile = sourceFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSourceFileResponse" /> class.
        /// </summary>
        public GetSourceFileResponse()
        {
        }
    }
}