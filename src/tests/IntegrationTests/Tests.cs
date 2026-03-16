namespace Instill.IntegrationTests;

[TestClass]
public partial class Tests
{
    public static InstillClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("API_KEY") ??
            Environment.GetEnvironmentVariable("INSTILL_API_TOKEN") ??
            TryReadDotEnvVariable("API_KEY") ??
            TryReadDotEnvVariable("INSTILL_API_TOKEN") ??
            throw new AssertInconclusiveException("INSTILL_API_TOKEN environment variable is not found.");

        var client = new InstillClient(apiKey);
        
        return client;
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
