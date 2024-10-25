using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

yamlOrJson = yamlOrJson
        .Replace("  v1beta", "  ")
        .Replace("#/definitions/v1beta", "#/definitions/")
        .Replace("MgmtPublicService_", string.Empty)
        .Replace("mgmtv1beta", string.Empty)
        .Replace("  v1alpha", "  ")
        .Replace("#/definitions/v1alpha", "#/definitions/")
        .Replace("  ArtifactPublicService", "  ")
        .Replace("#/definitions/ArtifactPublicService", "#/definitions/")
        .Replace("ArtifactPublicService_", string.Empty)
        .Replace("artifactv1alpha", string.Empty)
        
        // Fixing the Task schema because it conflicts with the Task class in C#
        .Replace("#/definitions/Task", "#/definitions/AITask")
        .Replace("  Task:", "  AITask:")
        
        // Fixing the Object schema because it conflicts with the Object class in C#
        .Replace("'#/definitions/Object'", "'#/definitions/AIObject'")
        .Replace("  Object:", "  AIObject:")
    ;

var openApiDocument = new OpenApiStringReader().Read(yamlOrJson, out var diagnostics);

openApiDocument.Components.SecuritySchemes["Bearer"].Type = SecuritySchemeType.Http;
openApiDocument.Components.SecuritySchemes["Bearer"].Scheme = "bearer";

openApiDocument.Components.Schemas["CreateCatalogResponse"]!.Required.Add("catalog");
openApiDocument.Components.Schemas["Catalog"]!.Required.Add("catalogId");

openApiDocument.Components.Schemas["UploadCatalogFileResponse"]!.Required.Add("file");
openApiDocument.Components.Schemas["File"]!.Required.Add("fileUid");

openApiDocument.Components.Schemas["ProcessCatalogFilesResponse"]!.Required.Add("files");
openApiDocument.Components.Schemas["ListCatalogFilesResponse"]!.Required.Add("files");

foreach (var pair in openApiDocument.Paths)
{
    // if (pair.Key.Contains("/v1alpha/"))
    // {
    //     foreach (var operation in pair.Value.Operations)
    //     {
    //         operation.Value.Extensions.Add("x-stage", new OpenApiString("alpha"));
    //     }
    // }
    // if (pair.Key.Contains("/v1beta/"))
    // {
    //     foreach (var operation in pair.Value.Operations)
    //     {
    //         operation.Value.Extensions.Add("x-stage", new OpenApiString("beta"));
    //     }
    // }
}

yamlOrJson = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(yamlOrJson, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    //Environment.Exit(1);
}

await File.WriteAllTextAsync(path, yamlOrJson);
