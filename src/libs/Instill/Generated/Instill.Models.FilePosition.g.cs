
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilePosition
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.UnitJsonConverter))]
        public global::Instill.Unit? Unit { get; set; }

        /// <summary>
        /// Position coordinates as an array<br/>
        /// For 1D: [position]<br/>
        /// For 2D: [x, y]<br/>
        /// For 3D: [x, y, z], etc.<br/>
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
        /// Initializes a new instance of the <see cref="FilePosition" /> class.
        /// </summary>
        /// <param name="unit">
        /// Included only in responses
        /// </param>
        /// <param name="coordinates">
        /// Position coordinates as an array<br/>
        /// For 1D: [position]<br/>
        /// For 2D: [x, y]<br/>
        /// For 3D: [x, y, z], etc.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilePosition(
            global::Instill.Unit? unit,
            global::System.Collections.Generic.IList<long>? coordinates)
        {
            this.Unit = unit;
            this.Coordinates = coordinates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilePosition" /> class.
        /// </summary>
        public FilePosition()
        {
        }
    }
}