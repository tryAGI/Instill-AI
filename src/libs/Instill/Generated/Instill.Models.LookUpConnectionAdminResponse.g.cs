
#nullable enable

namespace Instill
{
    /// <summary>
    /// LookUpConnectionAdminResponse contains the requested connection.
    /// </summary>
    public sealed partial class LookUpConnectionAdminResponse
    {
        /// <summary>
        /// The requested connection.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection")]
        public global::Instill.Connection? Connection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LookUpConnectionAdminResponse" /> class.
        /// </summary>
        /// <param name="connection">
        /// The requested connection.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LookUpConnectionAdminResponse(
            global::Instill.Connection? connection)
        {
            this.Connection = connection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LookUpConnectionAdminResponse" /> class.
        /// </summary>
        public LookUpConnectionAdminResponse()
        {
        }
    }
}