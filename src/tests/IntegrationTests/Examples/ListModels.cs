/*
order: 40
title: List Models
slug: list-models
*/

namespace Instill.IntegrationTests;

#pragma warning disable INSTILL_BETA_001
#pragma warning disable INSTILL_ALPHA_001

public partial class Tests
{
    //// Retrieve the list of AI models available in the Instill platform.

    [TestMethod]
    public async System.Threading.Tasks.Task Example_ListModels()
    {
        using var client = GetAuthenticatedClient();

        GetAuthenticatedUserResponse userResponse = await client.Namespace.MgmtPublicServiceGetAuthenticatedUserAsync();
        var namespaceName = $"namespaces/{userResponse.User.Id}";

        ListModelsResponse response = await client.Model.ModelPublicServiceListModelsAsync(
            parent: namespaceName);

        response.Should().NotBeNull();

        foreach (var model in response.Models ?? [])
        {
            Console.WriteLine($"Model: {model.Name}");
            Console.WriteLine($"  ID: {model.Id}");
            Console.WriteLine($"  Description: {model.Description}");
            Console.WriteLine();
        }
    }
}
