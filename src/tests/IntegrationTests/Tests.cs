namespace Instill.IntegrationTests;

[TestClass]
public partial class Tests
{
    public static InstillClient GetAuthenticatedClient()
    {
        var apiKey =
            GetNonEmptyEnvVar("API_KEY") ??
            GetNonEmptyEnvVar("INSTILL_API_TOKEN") ??
            TryReadDotEnvVariable("API_KEY") ??
            TryReadDotEnvVariable("INSTILL_API_TOKEN") ??
            throw new AssertInconclusiveException("INSTILL_API_TOKEN environment variable is not found.");

        var httpClient = new HttpClient(new InstillTransportInconclusiveHandler());
        var client = new InstillClient(apiKey, httpClient, disposeHttpClient: true);
        
        return client;
    }

    private static bool IsInstillTransportUnavailable(Exception exception)
    {
        for (var current = exception; current is not null; current = current.InnerException)
        {
            if (current.Message.Contains("unexpected EOF", StringComparison.OrdinalIgnoreCase) ||
                current.Message.Contains("0 bytes from the transport stream", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    private sealed class InstillTransportInconclusiveHandler : DelegatingHandler
    {
        public InstillTransportInconclusiveHandler()
            : base(new HttpClientHandler())
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            try
            {
                return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
            catch (HttpRequestException ex) when (IsInstillTransportUnavailable(ex))
            {
                throw new AssertInconclusiveException(
                    "Instill API TLS handshake failed before a response was received.",
                    ex);
            }
        }
    }

    private static string? GetNonEmptyEnvVar(string name)
    {
        var value = Environment.GetEnvironmentVariable(name);
        return string.IsNullOrWhiteSpace(value) ? null : value;
    }

    private static string? TryReadDotEnvVariable(string key)
    {
        for (var directory = new DirectoryInfo(Directory.GetCurrentDirectory()); directory is not null; directory = directory.Parent)
        {
            var envFilePath = Path.Combine(directory.FullName, ".env");
            if (!System.IO.File.Exists(envFilePath))
            {
                continue;
            }

            foreach (var rawLine in System.IO.File.ReadLines(envFilePath))
            {
                var line = rawLine.Trim();
                if (line.Length == 0 || line.StartsWith('#'))
                {
                    continue;
                }

                if (!line.StartsWith($"{key}=", StringComparison.Ordinal))
                {
                    continue;
                }

                var value = line[(key.Length + 1)..].Trim();
                if (value.Length >= 2 &&
                    ((value[0] == '"' && value[^1] == '"') ||
                     (value[0] == '\'' && value[^1] == '\'')))
                {
                    value = value[1..^1];
                }

                return value;
            }

            return null;
        }

        return null;
    }
}
