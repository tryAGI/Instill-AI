
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateObjectRequest represents a request to update an object.<br/>
    /// Follows AIP-134: resource's `name` field identifies it.
    /// </summary>
    public sealed partial class UpdateObjectBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.UpdateObjectBodyObject Object { get; set; }

        /// <summary>
        /// The update mask specifies which fields to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateMask")]
        public string? UpdateMask { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObjectBody" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="updateMask">
        /// The update mask specifies which fields to update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObjectBody(
            global::Instill.UpdateObjectBodyObject @object,
            string? updateMask)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.UpdateMask = updateMask;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObjectBody" /> class.
        /// </summary>
        public UpdateObjectBody()
        {
        }
    }
}