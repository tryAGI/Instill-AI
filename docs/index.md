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
> [!NOTE]  
> Most APIs are now marked as Alpha or Beta, and you need to do one of:
> - Hide it within the file via `#pragma warning disable INSTILL_BETA_001`
> - Hide it at the project level via `<NoWarn>$(NoWarn);INSTILL_BETA_001</NoWarn>`
```csharp
using Instill;

using var api = new InstillClient(apiKey);
using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(5));
var cancellationToken = cancellationTokenSource.Token;

CreateCatalogResponse createCatalogResponse = await client.Subscription.CreateCatalogAsync(
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

UploadCatalogFileResponse uploadFileResponse = await client.Subscription.UploadCatalogFileAsync(
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

ProcessCatalogFilesResponse processFilesResponse = await client.Subscription.ProcessCatalogFilesAsync(
    fileUids: [file.FileUid],
    cancellationToken: cancellationToken);

processFilesResponse.Files[0].ProcessStatus.Should().Be(FileProcessStatus.WAITING);

while (!cancellationToken.IsCancellationRequested)
{
    await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
    
    ListCatalogFilesResponse listFilesResponse = await client.Subscription.ListCatalogFilesAsync(
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

QuestionAnsweringResponse questionAnsweringResponse = await client.Subscription.QuestionAnsweringAsync(
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

DeleteCatalogResponse deleteCatalogResponse = await client.Subscription.DeleteCatalogAsync(
    namespaceId: "havendv",
    catalogId: catalog.CatalogId,
    cancellationToken: cancellationToken);
```
```
CatalogId: shakespeare_603611
Name: shakespeare_603611
Description: Works of Shakespeare
TotalFiles: 0
TotalTokens: 0
FileUid: 74fb1fa5-1ea8-4cde-8464-d6c5ceacdb19
Name: midsummer-nights-dream.pdf
Type: PDF
Size: 572679
TotalTokens: 0
TotalChunks: 0
Question: Who are the main characters involved in the love triangle in Act I?
Answer: The main characters involved in the love triangle in Act I are Hermia, Lysander, and Demetrius.
SimilarChunks:
  ChunkUid: 0eefa2e4-b236-45e8-934e-2c8b212b8c15
  SimilarityScore: 0,53560394
  TextContent: 
15 A Midsummer Night’s Dream ACT 1. SC. 1<br>Devoutly dotes, dotes in idolatry,<br>Upon this spotted and inconstant man.<br>THESEUS<br>I must confess that I have heard so much,<br>And with Demetrius thought to have spoke thereof;<br>But, being overfull of self-affairs, 115<br>My mind did lose it.—But, Demetrius, come,<br>And come, Egeus; you shall go with me.<br>I have some private schooling for you both.—<br>For you, fair Hermia, look you arm yourself<br>To fit your fancies to your father’s will, 120<br>Or else the law of Athens yields you up<br>(Which by no means we may extenuate)<br>To death or to a vow of single life.—<br>Come, my Hippolyta. What cheer, my love?—<br>Demetrius and Egeus, go along. 125<br>I must employ you in some business<br>Against our nuptial and confer with you<br>Of
  SourceFile: midsummer-nights-dream.pdf
----------------------------------------
  ChunkUid: 517ca21b-8762-4a57-a5ac-f924ccc8d862
  SimilarityScore: 0,5345083
  TextContent: 
17 A Midsummer Night’s Dream ACT 1. SC. 1<br>HERMIA<br>O spite! Too old to be engaged to young. 140<br>LYSANDER<br>Or else it stood upon the choice of friends—<br>HERMIA<br>O hell, to choose love by another’s eyes!<br>LYSANDER<br>Or, if there were a sympathy in choice,<br>War, death, or sickness did lay siege to it,<br>Making it momentany as a sound, 145<br>Swift as a shadow, short as any dream,<br>Brief as the lightning in the collied night,<br>That, in a spleen, unfolds both heaven and Earth,<br>And, ere a man hath power to say “Behold!”<br>The jaws of darkness do devour it up. 150<br>So quick bright things come to confusion.<br>HERMIA<br>If then true lovers have been ever crossed,<br>It stands as an edict in destiny.<br>Then let us teach our trial patience<br>Because it is a customary
  SourceFile: midsummer-nights-dream.pdf
----------------------------------------
  ChunkUid: acac8bf0-a7b2-4964-9a95-265ec3259813
  SimilarityScore: 0,53164166
  TextContent: 
23 A Midsummer Night’s Dream ACT 1. SC. 1<br>Keep word, Lysander. We must starve our sight<br>From lovers’ food till morrow deep midnight.<br>LYSANDER<br>I will, my Hermia. Hermia exits.<br>Helena, adieu. 230<br>As you on him, Demetrius dote on you!<br>Lysander exits.<br>HELENA<br>How happy some o’er other some can be!<br>Through Athens I am thought as fair as she.<br>But what of that? Demetrius thinks not so.<br>He will not know what all but he do know. 235<br>And, as he errs, doting on Hermia’s eyes,<br>So I, admiring of his qualities.<br>Things base and vile, holding no quantity,<br>Love can transpose to form and dignity.<br>Love looks not with the eyes but with the mind; 240<br>And therefore is winged Cupid painted blind.<br>Nor hath Love’s mind of any judgment taste.<br>Wings, and no
  SourceFile: midsummer-nights-dream.pdf
----------------------------------------
  ChunkUid: 8709c9fa-1d7c-4f8f-82d5-729211148fea
  SimilarityScore: 0,5229155
  TextContent: 
91 A Midsummer Night’s Dream ACT 3. SC. 2<br>ROBIN<br>Captain of our fairy band,<br>Helena is here at hand,<br>And the youth, mistook by me,<br>Pleading for a lover’s fee. 115<br>Shall we their fond pageant see?<br>Lord, what fools these mortals be!<br>OBERON<br>Stand aside. The noise they make<br>Will cause Demetrius to awake.<br>ROBIN<br>Then will two at once woo one. 120<br>That must needs be sport alone.<br>And those things do best please me<br>That befall prepost’rously.<br>They step aside.<br>Enter Lysander and Helena.<br>LYSANDER<br>Why should you think that I should woo in scorn?<br>Scorn and derision never come in tears. 125<br>Look when I vow, I weep; and vows so born,<br>In their nativity all truth appears.<br>How can these things in me seem scorn to you,<br>Bearing the badge of
  SourceFile: midsummer-nights-dream.pdf
----------------------------------------
  ChunkUid: ed846a1e-691c-46be-ad8e-43f9a55ee8ee
  SimilarityScore: 0,5222103
  TextContent: 
133 A Midsummer Night’s Dream ACT 4. SC. 1<br>Thereby to have defeated you and me:<br>You of your wife and me of my consent, 165<br>Of my consent that she should be your wife.<br>DEMETRIUS<br>My lord, fair Helen told me of their stealth,<br>Of this their purpose hither to this wood,<br>And I in fury hither followed them,<br>Fair Helena in fancy following me. 170<br>But, my good lord, I wot not by what power<br>(But by some power it is) my love to Hermia,<br>Melted as the snow, seems to me now<br>As the remembrance of an idle gaud<br>Which in my childhood I did dote upon, 175<br>And all the faith, the virtue of my heart,<br>The object and the pleasure of mine eye,<br>Is only Helena. To her, my lord,<br>Was I betrothed ere I saw Hermia.<br>But like a sickness did I loathe this food.
  SourceFile: midsummer-nights-dream.pdf
----------------------------------------
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