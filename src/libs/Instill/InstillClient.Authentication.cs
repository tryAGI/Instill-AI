namespace Instill;

#pragma warning disable CA1822

public sealed partial class InstillClient
{
    partial void Authorizing(HttpClient client, ref string apiKey)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new ArgumentException("API token cannot be empty.", nameof(apiKey));
        }

        apiKey = NormalizeAuthorizationHeaderValue(apiKey);
    }

    private static string NormalizeAuthorizationHeaderValue(string apiKey)
    {
        const string bearerPrefix = "Bearer ";

        var trimmed = apiKey.Trim();
        if (trimmed.StartsWith(bearerPrefix, StringComparison.OrdinalIgnoreCase))
        {
            return bearerPrefix + trimmed[bearerPrefix.Length..].Trim();
        }

        return bearerPrefix + trimmed;
    }
}
