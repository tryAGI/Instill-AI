
#nullable enable

namespace Instill
{
    /// <summary>
    /// Spec represents a specification data model.
    /// </summary>
    public sealed partial class Spec
    {
        /// <summary>
        /// Component specification.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("componentSpecification")]
        public object? ComponentSpecification { get; set; }

        /// <summary>
        /// Data specifications.<br/>
        /// The key represents the task, and the value is the corresponding data_specification.<br/>
        /// Note: This field will be renamed to task_specifications in the future.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSpecifications")]
        public global::System.Collections.Generic.Dictionary<string, global::Instill.DataSpecification>? DataSpecifications { get; set; }

        /// <summary>
        /// Event specifications.<br/>
        /// The key represents the event, and the value is the corresponding event_specification.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventSpecifications")]
        public global::System.Collections.Generic.Dictionary<string, global::Instill.EventSpecification>? EventSpecifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Spec" /> class.
        /// </summary>
        /// <param name="componentSpecification">
        /// Component specification.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dataSpecifications">
        /// Data specifications.<br/>
        /// The key represents the task, and the value is the corresponding data_specification.<br/>
        /// Note: This field will be renamed to task_specifications in the future.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="eventSpecifications">
        /// Event specifications.<br/>
        /// The key represents the event, and the value is the corresponding event_specification.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Spec(
            object? componentSpecification,
            global::System.Collections.Generic.Dictionary<string, global::Instill.DataSpecification>? dataSpecifications,
            global::System.Collections.Generic.Dictionary<string, global::Instill.EventSpecification>? eventSpecifications)
        {
            this.ComponentSpecification = componentSpecification;
            this.DataSpecifications = dataSpecifications;
            this.EventSpecifications = eventSpecifications;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Spec" /> class.
        /// </summary>
        public Spec()
        {
        }
    }
}