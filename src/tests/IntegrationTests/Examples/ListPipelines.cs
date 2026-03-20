/*
order: 30
title: List Pipelines
slug: list-pipelines
*/

namespace Instill.IntegrationTests;

#pragma warning disable INSTILL_BETA_001
#pragma warning disable INSTILL_ALPHA_001

public partial class Tests
{
    //// Retrieve the list of available pipelines in the Instill platform.

    [TestMethod]
    public async System.Threading.Tasks.Task Example_ListPipelines()
    {
        using var client = GetAuthenticatedClient();

        ListPipelinesResponse response = await client.Pipeline.PipelinePublicServiceListPipelinesAsync(
            parent: "users/me");

        response.Should().NotBeNull();

        foreach (var pipeline in response.Pipelines ?? [])
        {
            Console.WriteLine($"Pipeline: {pipeline.Name}");
            Console.WriteLine($"  ID: {pipeline.Id}");
            Console.WriteLine($"  Description: {pipeline.Description}");
            Console.WriteLine();
        }
    }
}
