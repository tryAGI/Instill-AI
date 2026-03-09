using System.Text.RegularExpressions;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

// Replaces strings like
// aspect_ratio: '2024-10-25T16:09:00.0000000+00:00'
// with
// aspect_ratio: '16:9'
yamlOrJson = Regex.Replace(yamlOrJson, @"aspect_ratio: '.*?'", "aspect_ratio: '16:9'");

await File.WriteAllTextAsync(path, yamlOrJson);
