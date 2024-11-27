#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Update an app's information<br/>
        /// Updates the information of an app.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateAppResponse> AppPublicServiceUpdateAppAsync(
            string namespaceId,
            string appId,
            global::Instill.UpdateAppBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an app's information<br/>
        /// Updates the information of an app.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="newAppId">
        /// The app id needs to follow the kebab case format.<br/>
        /// if the new app id is not provided, the app id will not be updated.
        /// </param>
        /// <param name="newDescription">
        /// The app description.<br/>
        /// If the new description is empty, the description will be set to empty.
        /// </param>
        /// <param name="newTags">
        /// The app tags.<br/>
        /// If the new tags is empty, the tags will be set to empty.
        /// </param>
        /// <param name="lastAiAssistantAppCatalogUid">
        /// last AI assistant app catalog uid<br/>
        /// If the last AI assistant app catalog uid is empty, the last AI assistant app catalog uid will be set to empty.
        /// </param>
        /// <param name="lastAiAssistantAppTopK">
        /// last AI assistant app top k<br/>
        /// If the last AI assistant app top k is empty, the last AI assistant app top k will be set to empty.
        /// </param>
        /// <param name="aiAssistantApp"></param>
        /// <param name="aiAgentApp"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateAppResponse> AppPublicServiceUpdateAppAsync(
            string namespaceId,
            string appId,
            string? newAppId = default,
            string? newDescription = default,
            global::System.Collections.Generic.IList<string>? newTags = default,
            string? lastAiAssistantAppCatalogUid = default,
            int? lastAiAssistantAppTopK = default,
            global::Instill.AIAssistantAppMetadata? aiAssistantApp = default,
            global::Instill.AIAgentAppMetadata? aiAgentApp = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}