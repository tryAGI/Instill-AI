using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
        .Replace("  v1beta", "  ")
        .Replace("#/definitions/v1beta", "#/definitions/")
    ;

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

foreach (var (_, operation) in openApiDocument.Paths.SelectMany(x => x.Value.Operations))
{
    operation.OperationId = operation.OperationId.Replace("MgmtPublicService_", string.Empty);
}

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);
return;