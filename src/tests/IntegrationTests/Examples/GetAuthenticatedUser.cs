/*
order: 20
title: Get Authenticated User
slug: get-authenticated-user
*/

namespace Instill.IntegrationTests;

#pragma warning disable INSTILL_BETA_001
#pragma warning disable INSTILL_ALPHA_001

public partial class Tests
{
    //// Retrieve information about the currently authenticated Instill user.

    [TestMethod]
    public async System.Threading.Tasks.Task Example_GetAuthenticatedUser()
    {
        using var client = GetAuthenticatedClient();

        GetAuthenticatedUserResponse response = await client.Namespace.MgmtPublicServiceGetAuthenticatedUserAsync();

        var user = response.User;
        user.Should().NotBeNull();
        user.Id.Should().NotBeNullOrEmpty();

        Console.WriteLine($"User ID: {user.Id}");
        Console.WriteLine($"Name: {user.Name}");
    }
}
