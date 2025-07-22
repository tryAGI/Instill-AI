
#nullable enable

namespace Instill
{
    /// <summary>
    /// The Organization stats.
    /// </summary>
    public sealed partial class OrganizationStats
    {
        /// <summary>
        /// The number of users in the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userCount")]
        public int? UserCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationStats" /> class.
        /// </summary>
        /// <param name="userCount">
        /// The number of users in the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationStats(
            int? userCount)
        {
            this.UserCount = userCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationStats" /> class.
        /// </summary>
        public OrganizationStats()
        {
        }
    }
}