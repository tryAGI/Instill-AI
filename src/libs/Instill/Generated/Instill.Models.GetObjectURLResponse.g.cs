
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetObjectURLResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectUrl")]
        public global::Instill.ObjectURL? ObjectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectURLResponse" /> class.
        /// </summary>
        /// <param name="objectUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetObjectURLResponse(
            global::Instill.ObjectURL? objectUrl)
        {
            this.ObjectUrl = objectUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectURLResponse" /> class.
        /// </summary>
        public GetObjectURLResponse()
        {
        }
    }
}