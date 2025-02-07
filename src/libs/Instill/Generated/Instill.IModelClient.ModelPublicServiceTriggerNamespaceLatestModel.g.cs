#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Trigger model inference<br/>
        /// Triggers the latest deployed model version to infer the result of a set of task or<br/>
        /// questions.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.TriggerNamespaceLatestModelResponse> ModelPublicServiceTriggerNamespaceLatestModelAsync(
            string namespaceId,
            string modelId,
            global::Instill.TriggerNamespaceLatestModelBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trigger model inference<br/>
        /// Triggers the latest deployed model version to infer the result of a set of task or<br/>
        /// questions.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="taskInputs">
        /// Model inference inputs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.TriggerNamespaceLatestModelResponse> ModelPublicServiceTriggerNamespaceLatestModelAsync(
            string namespaceId,
            string modelId,
            global::System.Collections.Generic.IList<object> taskInputs,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}