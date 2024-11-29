
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListToolsResponse represents a response for listing tools.
    /// </summary>
    public sealed partial class ListToolsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Instill.Tool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolsResponse" /> class.
        /// </summary>
        /// <param name="tools"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListToolsResponse(
            global::System.Collections.Generic.IList<global::Instill.Tool>? tools)
        {
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolsResponse" /> class.
        /// </summary>
        public ListToolsResponse()
        {
        }
    }
}