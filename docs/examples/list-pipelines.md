# List Pipelines



This example assumes `using Instill;` is in scope and `apiKey` contains your Instill API key.

```csharp
using var client = new InstillClient(apiKey);

ListPipelinesResponse response = await client.Pipeline.PipelinePublicServiceListPipelinesAsync(
    parent: "users/me");

foreach (var pipeline in response.Pipelines ?? [])
{
    Console.WriteLine($"Pipeline: {pipeline.Name}");
    Console.WriteLine($"  ID: {pipeline.Id}");
    Console.WriteLine($"  Description: {pipeline.Description}");
    Console.WriteLine();
}
```