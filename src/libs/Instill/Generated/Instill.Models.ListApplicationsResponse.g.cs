
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListApplicationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applicationNames")]
        public global::System.Collections.Generic.IList<string>? ApplicationNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApplicationsResponse" /> class.
        /// </summary>
        /// <param name="applicationNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListApplicationsResponse(
            global::System.Collections.Generic.IList<string>? applicationNames)
        {
            this.ApplicationNames = applicationNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApplicationsResponse" /> class.
        /// </summary>
        public ListApplicationsResponse()
        {
        }
    }
}