using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var artifactPath = args[1];
var text = await File.ReadAllTextAsync(path);
var artifactText = await File.ReadAllTextAsync(artifactPath);

text = text
        .Replace("  v1beta", "  ")
        .Replace("#/definitions/v1beta", "#/definitions/")
        .Replace("MgmtPublicService_", string.Empty)
        .Replace("mgmtv1beta", string.Empty)
    ;
artifactText = artifactText
        .Replace("  v1alpha", "  ")
        .Replace("#/definitions/v1alpha", "#/definitions/")
        .Replace("  ArtifactPublicService", "  ")
        .Replace("#/definitions/ArtifactPublicService", "#/definitions/")
        .Replace("ArtifactPublicService_", string.Empty)
        .Replace("artifactv1alpha", string.Empty)
    ;

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);
var artifactOpenApiDocument = new OpenApiStringReader().Read(artifactText, out var artifactDiagnostics);

foreach (var pair in artifactOpenApiDocument.Components.Schemas)
{
    if (openApiDocument.Components.Schemas.ContainsKey(pair.Key))
    {
        Console.WriteLine($"Removing {pair.Key} because it already exists in the document");
        openApiDocument.Components.Schemas.Remove(pair.Key);
    }
    
    openApiDocument.Components.Schemas.Add(pair);
}
foreach (var pair in artifactOpenApiDocument.Paths)
{
    openApiDocument.Paths.Add(pair.Key, pair.Value);
}

openApiDocument.Components.SecuritySchemes["Bearer"].Type = SecuritySchemeType.Http;
openApiDocument.Components.SecuritySchemes["Bearer"].Scheme = "bearer";

openApiDocument.Components.Schemas["CreateCatalogResponse"]!.Required.Add("catalog");
openApiDocument.Components.Schemas["Catalog"]!.Required.Add("catalogId");

openApiDocument.Components.Schemas["UploadCatalogFileResponse"]!.Required.Add("file");
openApiDocument.Components.Schemas["File"]!.Required.Add("fileUid");

openApiDocument.Components.Schemas["ProcessCatalogFilesResponse"]!.Required.Add("files");
openApiDocument.Components.Schemas["ListCatalogFilesResponse"]!.Required.Add("files");

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