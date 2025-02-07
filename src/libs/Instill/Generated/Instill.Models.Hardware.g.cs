
#nullable enable

namespace Instill
{
    /// <summary>
    /// Hardware describes the hardware title and string value that backend consumes.
    /// </summary>
    public sealed partial class Hardware
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Hardware" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Hardware(
            string? title,
            string? value)
        {
            this.Title = title;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hardware" /> class.
        /// </summary>
        public Hardware()
        {
        }
    }
}