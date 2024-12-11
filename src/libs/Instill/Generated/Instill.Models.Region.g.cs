
#nullable enable

namespace Instill
{
    /// <summary>
    /// Region describes the supported cloud provider and regions, with<br/>
    /// their supported GPU respectively.
    /// </summary>
    public sealed partial class Region
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regionName")]
        public string? RegionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        public global::System.Collections.Generic.IList<global::Instill.Hardware>? Hardware { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Region" /> class.
        /// </summary>
        /// <param name="regionName"></param>
        /// <param name="hardware"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Region(
            string? regionName,
            global::System.Collections.Generic.IList<global::Instill.Hardware>? hardware)
        {
            this.RegionName = regionName;
            this.Hardware = hardware;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Region" /> class.
        /// </summary>
        public Region()
        {
        }
    }
}