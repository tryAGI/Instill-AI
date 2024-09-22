# Instill

[![Nuget package](https://img.shields.io/nuget/vpre/Instill)](https://www.nuget.org/packages/Instill/)
[![dotnet](https://github.com/tryAGI/Instill/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Instill/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Instill)](https://github.com/tryAGI/Instill/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Instill OpenAPI specification](https://raw.githubusercontent.com/Instill/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Instill;

using var api = new InstillClient(apiKey);
using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(5));
var cancellationToken = cancellationTokenSource.Token;

CreateCatalogResponse createCatalogResponse = await client.Catalog.CreateCatalogAsync(
    namespaceId: "havendv",
    name: $"shakespeare_{Random.Shared.Next(1_000_000)}",
    description: "Works of Shakespeare",
    cancellationToken: cancellationToken);

var catalog = createCatalogResponse.Catalog;
Console.WriteLine($"CatalogId: {catalog.CatalogId}");
Console.WriteLine($"Name: {catalog.Name}");
Console.WriteLine($"Description: {catalog.Description}");
Console.WriteLine($"TotalFiles: {catalog.TotalFiles}");
Console.WriteLine($"TotalTokens: {catalog.TotalTokens}");

UploadCatalogFileResponse uploadFileResponse = await client.Catalog.UploadCatalogFileAsync(
    namespaceId: "havendv",
    catalogId: catalog.CatalogId,
    name: "midsummer-nights-dream.pdf",
    type: FileType.PDF,
    content: Convert.ToBase64String(H.Resources.midsummer_nights_dream_pdf.AsBytes()),
    cancellationToken: cancellationToken);

var file = uploadFileResponse.File;
Console.WriteLine($"FileUid: {file.FileUid}");
Console.WriteLine($"Name: {file.Name}");
Console.WriteLine($"Type: {file.Type}");
Console.WriteLine($"Size: {file.Size}");
Console.WriteLine($"TotalTokens: {file.TotalTokens}");
Console.WriteLine($"TotalChunks: {file.TotalChunks}");

ProcessCatalogFilesResponse processFilesResponse = await client.Catalog.ProcessCatalogFilesAsync(
    fileUids: [file.FileUid],
    cancellationToken: cancellationToken);

processFilesResponse.Files[0].ProcessStatus.Should().Be(FileProcessStatus.WAITING);

while (!cancellationToken.IsCancellationRequested)
{
    await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
    
    ListCatalogFilesResponse listFilesResponse = await client.Catalog.ListCatalogFilesAsync(
        namespaceId: "havendv",
        catalogId: catalog.CatalogId,
        cancellationToken: cancellationToken);

    if (listFilesResponse.Files[0].ProcessStatus is
            FileProcessStatus.COMPLETED or
            FileProcessStatus.FAILED)
    {
        break;
    }
}

const string question = "Who are the main characters involved in the love triangle in Act I?";
Console.WriteLine($"Question: {question}");

QuestionAnsweringResponse questionAnsweringResponse = await client.Catalog.QuestionAnsweringAsync(
    namespaceId: "havendv",
    catalogId: catalog.CatalogId,
    question: question,
    topK: 5,
    cancellationToken: cancellationToken);

Console.WriteLine($"Answer: {questionAnsweringResponse.Answer}");
// Answer: The main characters involved in the love triangle in Act I are Hermia, Lysander, and Demetrius.

Console.WriteLine("SimilarChunks:");

foreach (var chunk in questionAnsweringResponse.SimilarChunks ?? [])
{
    Console.WriteLine($"  ChunkUid: {chunk.ChunkUid}");
    Console.WriteLine($"  SimilarityScore: {chunk.SimilarityScore}");
    Console.WriteLine($"  TextContent: {chunk.TextContent}");
    Console.WriteLine($"  SourceFile: {chunk.SourceFile}");
    Console.WriteLine("----------------------------------------");
}

DeleteCatalogResponse deleteCatalogResponse = await client.Catalog.DeleteCatalogAsync(
    namespaceId: "havendv",
    catalogId: catalog.CatalogId,
    cancellationToken: cancellationToken);
```

## Support

Priority place for bugs: https://github.com/tryAGI/Instill/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Instill/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).