namespace Instill.IntegrationTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public InstillClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("INSTILL_API_TOKEN") ??
            throw new AssertInconclusiveException("INSTILL_API_TOKEN environment variable is not found.");

        var client = new InstillClient(apiKey);
        
        return client;
    }
}
