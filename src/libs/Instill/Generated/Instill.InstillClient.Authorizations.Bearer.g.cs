
#nullable enable

namespace Instill
{
    public sealed partial class InstillClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorization = new global::Instill.EndPointAuthorization
            {
                Name = "Bearer",
                Value = apiKey,
            };
        }
    }
}