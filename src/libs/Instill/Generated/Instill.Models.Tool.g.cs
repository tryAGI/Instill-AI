
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// The tool name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The tool connection key(used connection id in recipe) and value(connection uid from namespace).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections")]
        public global::System.Collections.Generic.Dictionary<string, string>? Connections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="name">
        /// The tool name.
        /// </param>
        /// <param name="connections">
        /// The tool connection key(used connection id in recipe) and value(connection uid from namespace).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Tool(
            string? pipelineId,
            string? name,
            global::System.Collections.Generic.Dictionary<string, string>? connections)
        {
            this.PipelineId = pipelineId;
            this.Name = name;
            this.Connections = connections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        public Tool()
        {
        }
    }
}