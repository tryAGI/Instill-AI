
#nullable enable

namespace Instill
{
    /// <summary>
    /// Reference represents the position of a chunk within its source file.
    /// </summary>
    public sealed partial class Reference
    {
        /// <summary>
        /// Start position of the chunk within the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public global::Instill.FilePosition? Start { get; set; }

        /// <summary>
        /// End position of the chunk within the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::Instill.FilePosition? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Reference" /> class.
        /// </summary>
        /// <param name="start">
        /// Start position of the chunk within the file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="end">
        /// End position of the chunk within the file.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Reference(
            global::Instill.FilePosition? start,
            global::Instill.FilePosition? end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reference" /> class.
        /// </summary>
        public Reference()
        {
        }
    }
}