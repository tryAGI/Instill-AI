#nullable enable

namespace Instill
{
    public partial interface Ix__ModelClient
    {
        /// <summary>
        /// Trigger model inference<br/>
        /// Triggers a deployed model to infer the result of a set of task or<br/>
        /// questions.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="version"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.TriggerNamespaceModelResponse> ModelPublicServiceTriggerNamespaceModelAsync(
            string namespaceId,
            string modelId,
            string version,
            global::Instill.TriggerNamespaceModelBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trigger model inference<br/>
        /// Triggers a deployed model to infer the result of a set of task or<br/>
        /// questions.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="version"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="taskInputs">
        /// Model inference inputs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.TriggerNamespaceModelResponse> ModelPublicServiceTriggerNamespaceModelAsync(
            string namespaceId,
            string modelId,
            string version,
            global::System.Collections.Generic.IList<object> taskInputs,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}