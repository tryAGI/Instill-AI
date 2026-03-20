# Quickstart Data



This example assumes `using Instill;` is in scope and `apiKey` contains your Instill API key.

```csharp
using var client = new InstillClient(apiKey);
using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(5));
var cancellationToken = cancellationTokenSource.Token;

GetAuthenticatedUserResponse getAuthenticatedUserResponse = await client.Namespace.MgmtPublicServiceGetAuthenticatedUserAsync(
    cancellationToken: cancellationToken);

var authenticatedUser = getAuthenticatedUserResponse.User;

var namespaceName = $"namespaces/{authenticatedUser.Id}";
string? knowledgeBaseName = null;
string? fileName = null;

try
{
    CreateKnowledgeBaseResponse createKnowledgeBaseResponse = await client.Artifact.ArtifactPublicServiceCreateKnowledgeBaseAsync(
        parent: namespaceName,
        displayName: $"shakespeare-{Random.Shared.Next(1_000_000)}",
        description: "Works of Shakespeare",
        cancellationToken: cancellationToken);

    var knowledgeBase = createKnowledgeBaseResponse.KnowledgeBase;
    knowledgeBaseName = knowledgeBase.Name!;

    Console.WriteLine($"KnowledgeBaseName: {knowledgeBaseName}");
    Console.WriteLine($"Id: {knowledgeBase.Id}");
    Console.WriteLine($"DisplayName: {knowledgeBase.DisplayName}");
    Console.WriteLine($"Description: {knowledgeBase.Description}");
    Console.WriteLine($"TotalFiles: {knowledgeBase.TotalFiles}");
    Console.WriteLine($"TotalTokens: {knowledgeBase.TotalTokens}");

    CreateFileResponse createFileResponse = await client.Artifact.ArtifactPublicServiceCreateFileAsync(
        parent: knowledgeBaseName,
        displayName: "midsummer-nights-dream.pdf",
        type: FileType.TypePdf,
        content: Convert.ToBase64String(H.Resources.midsummer_nights_dream_pdf.AsBytes()),
        cancellationToken: cancellationToken);

    var file = createFileResponse.File;
    fileName = file.Name!;

    Console.WriteLine($"FileName: {fileName}");
    Console.WriteLine($"Id: {file.Id}");
    Console.WriteLine($"DisplayName: {file.DisplayName}");
    Console.WriteLine($"Type: {file.Type}");
    Console.WriteLine($"ProcessStatus: {file.ProcessStatus}");
    Console.WriteLine($"Size: {file.Size}");
    Console.WriteLine($"TotalTokens: {file.TotalTokens}");
    Console.WriteLine($"TotalChunks: {file.TotalChunks}");

    while (!cancellationToken.IsCancellationRequested)
    {
        GetFileResponse getFileResponse = await client.Artifact.ArtifactPublicServiceGetFileAsync(
            fileName,
            cancellationToken: cancellationToken);

        file = getFileResponse.File;

        Console.WriteLine($"PolledProcessStatus: {file.ProcessStatus}");
        Console.WriteLine($"PolledProcessOutcome: {file.ProcessOutcome}");

        if (file.ProcessStatus is FileProcessStatus.Completed or FileProcessStatus.Failed)
        {
            break;
        }

        await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
    }

    if (file.ProcessStatus == FileProcessStatus.Failed)
    {
        if (file.ProcessOutcome?.Contains("insufficient credit", StringComparison.OrdinalIgnoreCase) == true)
        {
            throw new AssertInconclusiveException($"Artifact processing requires credits: {file.ProcessOutcome}");
        }

    }

    const string question = "Who are the main characters involved in the love triangle in Act I?";
    Console.WriteLine($"Question: {question}");

    SearchChunksResponse searchChunksResponse = await client.Artifact.ArtifactPublicServiceSearchChunksAsync(
        parent: namespaceName,
        knowledgeBase: knowledgeBaseName,
        textPrompt: question,
        topK: 5,
        cancellationToken: cancellationToken);

    Console.WriteLine("SimilarChunks:");

    foreach (var chunk in searchChunksResponse.SimilarChunks ?? [])
    {
        Console.WriteLine($"  Chunk: {chunk.Chunk}");
        Console.WriteLine($"  SimilarityScore: {chunk.SimilarityScore}");
        Console.WriteLine($"  TextContent: {chunk.TextContent}");
        Console.WriteLine($"  File: {chunk.File}");
        Console.WriteLine("----------------------------------------");
    }
}
finally
{
    if (fileName is not null)
    {
        try
        {
            DeleteFileResponse deleteFileResponse = await client.Artifact.ArtifactPublicServiceDeleteFileAsync(
                fileName,
                cancellationToken: CancellationToken.None);

        }
        catch (Exception exception)
        {
            Console.WriteLine($"DeleteFile cleanup failed: {exception.Message}");
        }
    }

    if (knowledgeBaseName is not null)
    {
        try
        {
            DeleteKnowledgeBaseResponse deleteKnowledgeBaseResponse = await client.Artifact.ArtifactPublicServiceDeleteKnowledgeBaseAsync(
                knowledgeBaseName,
                cancellationToken: CancellationToken.None);

        }
        catch (Exception exception)
        {
            Console.WriteLine($"DeleteKnowledgeBase cleanup failed: {exception.Message}");
        }
    }
}
```