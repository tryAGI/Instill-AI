
#nullable enable

namespace Instill
{
    /// <summary>
    /// Component specification.
    /// </summary>
    public sealed partial class SpecComponentSpecification
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecComponentSpecification" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SpecComponentSpecification(
 )
        {
        }
    }
}