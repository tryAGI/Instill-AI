#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Trigger model inference asynchronously<br/>
        /// Triggers the latest deployed model version to infer the result of a set of<br/>
        /// task or questions.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.TriggerAsyncModelResponse> ModelPublicServiceTriggerAsyncModelAsync(
            string name1,

            global::Instill.TriggerAsyncModelBody request,
            string? instillRequesterUid = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger model inference asynchronously<br/>
        /// Triggers the latest deployed model version to infer the result of a set of<br/>
        /// task or questions.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="taskInputs">
        /// Model inference inputs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.TriggerAsyncModelResponse> ModelPublicServiceTriggerAsyncModelAsync(
            string name1,
            global::System.Collections.Generic.IList<object> taskInputs,
            string? instillRequesterUid = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}