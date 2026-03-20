# List Models



This example assumes `using Instill;` is in scope and `apiKey` contains your Instill API key.

```csharp
using var client = new InstillClient(apiKey);

ListModelsResponse response = await client.Model.ModelPublicServiceListModelsAsync(
    parent: "users/me");

foreach (var model in response.Models ?? [])
{
    Console.WriteLine($"Model: {model.Name}");
    Console.WriteLine($"  ID: {model.Id}");
    Console.WriteLine($"  Description: {model.Description}");
    Console.WriteLine();
}
```