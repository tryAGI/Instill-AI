namespace Instill.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetRemainingCredit()
    {
        using var client = GetAuthenticatedClient();

        GetRemainingCreditResponse response = await client.Subscription.GetRemainingCreditAsync(namespaceId: "havendv");
        
        Console.WriteLine($"Perishable: {response.Perishable}");
        Console.WriteLine($"Imperishable: {response.Imperishable}");
        Console.WriteLine($"Total: {response.Total}");
        
        response.Should().NotBeNull();
        response.Total.Should().BeGreaterThan(0);
    }
}
