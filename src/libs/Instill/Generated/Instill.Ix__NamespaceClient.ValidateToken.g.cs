#nullable enable

namespace Instill
{
    public partial interface Ix__NamespaceClient
    {
        /// <summary>
        /// Validate an API token<br/>
        /// Validates an API token.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ValidateTokenResponse> ValidateTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}