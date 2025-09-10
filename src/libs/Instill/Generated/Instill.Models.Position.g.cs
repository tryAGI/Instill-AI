
#nullable enable

namespace Instill
{
    /// <summary>
    /// Position represents a position within a file using a specific unit. The<br/>
    /// number of dimensions of the position value depends on the unit type.
    /// </summary>
    public sealed partial class Position
    {
        /// <summary>
        /// Unit of measurement for the position.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.UnitJsonConverter))]
        public global::Instill.Unit? Unit { get; set; }

        /// <summary>
        /// Position value.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinates")]
        public global::System.Collections.Generic.IList<long>? Coordinates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Position" /> class.
        /// </summary>
        /// <param name="unit">
        /// Unit of measurement for the position.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="coordinates">
        /// Position value.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Position(
            global::Instill.Unit? unit,
            global::System.Collections.Generic.IList<long>? coordinates)
        {
            this.Unit = unit;
            this.Coordinates = coordinates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Position" /> class.
        /// </summary>
        public Position()
        {
        }
    }
}