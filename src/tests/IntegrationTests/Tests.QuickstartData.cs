namespace Instill.IntegrationTests;

#pragma warning disable INSTILL_BETA_001
#pragma warning disable INSTILL_ALPHA_001

public partial class Tests
{
    [TestMethod]
    public async Task QuickstartData()
    {
        using var client = GetAuthenticatedClient();
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(5));
        var cancellationToken = cancellationTokenSource.Token;

        CreateCatalogResponse createCatalogResponse = await client.Artifact.CreateCatalogAsync(
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
        
        catalog.Should().NotBeNull();
        catalog.CatalogId.Should().NotBeNull();
        
        UploadCatalogFileResponse uploadFileResponse = await client.Artifact.UploadCatalogFileAsync(
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
        
        file.Should().NotBeNull();
        file.FileUid.Should().NotBeNull();
        
        ProcessCatalogFilesResponse processFilesResponse = await client.Artifact.ProcessCatalogFilesAsync(
            fileUids: [file.FileUid],
            cancellationToken: cancellationToken);
        
        processFilesResponse.Files[0].ProcessStatus.Should().Be(FileProcessStatus.WAITING);

        while (!cancellationToken.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
            
            ListCatalogFilesResponse listFilesResponse = await client.Artifact.ListCatalogFilesAsync(
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
        
        QuestionAnsweringResponse questionAnsweringResponse = await client.Artifact.QuestionAnsweringAsync(
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
        
        DeleteCatalogResponse deleteCatalogResponse = await client.Artifact.DeleteCatalogAsync(
            namespaceId: "havendv",
            catalogId: catalog.CatalogId,
            cancellationToken: cancellationToken);
        
        deleteCatalogResponse.Catalog?.CatalogId.Should().Be(catalog.CatalogId);
    }
}
