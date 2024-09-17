namespace Instill.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task QuickstartData()
    {
        using var client = GetAuthenticatedClient();
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(5));
        var cancellationToken = cancellationTokenSource.Token;

        CreateCatalogResponse createCatalogResponse = await client.Catalog.CreateCatalogAsync(
            namespaceId: "havendv",
            name: "shakespeare",
            description: "Works of Shakespeare",
            cancellationToken: cancellationToken);
        
        var catalog = createCatalogResponse.Catalog?.Value1;
        Console.WriteLine($"CatalogId: {catalog?.CatalogId}");
        Console.WriteLine($"Name: {catalog?.Name}");
        Console.WriteLine($"Description: {catalog?.Description}");
        Console.WriteLine($"TotalFiles: {catalog?.TotalFiles}");
        Console.WriteLine($"TotalTokens: {catalog?.TotalTokens}");
        
        catalog.Should().NotBeNull();
        catalog?.CatalogId.Should().NotBeNull();
        
        UploadCatalogFileResponse uploadFileResponse = await client.Catalog.UploadCatalogFileAsync(
            namespaceId: "havendv",
            catalogId: catalog?.CatalogId!,
            name: "midsummer-nights-dream.pdf",
            type: FileType2.FILETYPEPDF,
            content: Convert.ToBase64String(H.Resources.midsummer_nights_dream_pdf.AsBytes()),
            // createTime: DateTime.UtcNow,
            // updateTime: DateTime.UtcNow,
            // deleteTime: DateTime.UtcNow,
            cancellationToken: cancellationToken);
        
        var file = uploadFileResponse.File?.Value1;
        Console.WriteLine($"FileUid: {file?.FileUid}");
        Console.WriteLine($"Name: {file?.Name}");
        Console.WriteLine($"Type: {file?.Type.Value1}");
        Console.WriteLine($"Size: {file?.Size}");
        Console.WriteLine($"TotalTokens: {file?.TotalTokens}");
        Console.WriteLine($"TotalChunks: {file?.TotalChunks}");
        
        file.Should().NotBeNull();
        file?.FileUid.Should().NotBeNull();
        
        ProcessCatalogFilesResponse processFilesResponse = await client.Catalog.ProcessCatalogFilesAsync(
            fileUids: [file?.FileUid!],
            cancellationToken: cancellationToken);
        
        processFilesResponse.Files?[0].ProcessStatus?.Value1.Should().Be(FileProcessStatus2.FILEPROCESSSTATUSWAITING);

        while (!cancellationToken.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
            
            ListCatalogFilesResponse listFilesResponse = await client.Catalog.ListCatalogFilesAsync(
                namespaceId: "havendv",
                catalogId: catalog?.CatalogId!,
                cancellationToken: cancellationToken);

            if (listFilesResponse.Files?[0].ProcessStatus?.Value1 is
                    FileProcessStatus2.FILEPROCESSSTATUSCOMPLETED or
                    FileProcessStatus2.FILEPROCESSSTATUSFAILED)
            {
                break;
            }
        }
        
        const string question = "Who are the main characters involved in the love triangle in Act I?";
        Console.WriteLine($"Question: {question}");
        
        QuestionAnsweringResponse questionAnsweringResponse = await client.Catalog.QuestionAnsweringAsync(
            namespaceId: "havendv",
            catalogId: catalog?.CatalogId!,
            question: question,
            topK: 5,
            cancellationToken: cancellationToken);
        
        Console.WriteLine($"Answer: {questionAnsweringResponse.Answer}");
        Console.WriteLine("SimilarChunks:");

        foreach (var chunk in questionAnsweringResponse.SimilarChunks ?? [])
        {
            Console.WriteLine($"  ChunkUid: {chunk.ChunkUid}");
            Console.WriteLine($"  SimilarityScore: {chunk.SimilarityScore}");
            Console.WriteLine($"  TextContent: {chunk.TextContent}");
            Console.WriteLine($"  SourceFile: {chunk.SourceFile}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
