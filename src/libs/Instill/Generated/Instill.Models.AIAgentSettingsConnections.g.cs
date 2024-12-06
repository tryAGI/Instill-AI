
#nullable enable

namespace Instill
{
    /// <summary>
    /// connection key(used connection id in recipe) and value(connection uid from namespace).
    /// </summary>
    public sealed partial class AIAgentSettingsConnections
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIAgentSettingsConnections" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AIAgentSettingsConnections(
 )
        {
        }
    }
}