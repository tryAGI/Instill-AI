
#nullable enable

namespace Instill
{
    /// <summary>
    /// Permission defines how a table can be used.
    /// </summary>
    public sealed partial class TablePermission
    {
        /// <summary>
        /// Defines whether the table can be modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canEdit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablePermission" /> class.
        /// </summary>
        /// <param name="canEdit">
        /// Defines whether the table can be modified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TablePermission(
            bool? canEdit)
        {
            this.CanEdit = canEdit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablePermission" /> class.
        /// </summary>
        public TablePermission()
        {
        }
    }
}