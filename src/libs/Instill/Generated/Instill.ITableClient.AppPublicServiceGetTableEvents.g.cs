#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Get table events<br/>
        /// Returns a list of events for a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.AppPublicServiceGetTableEventsResponse> AppPublicServiceGetTableEventsAsync(
            string namespaceId,
            string tableUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}