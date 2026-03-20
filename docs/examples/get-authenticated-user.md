# Get Authenticated User



This example assumes `using Instill;` is in scope and `apiKey` contains your Instill API key.

```csharp
using var client = new InstillClient(apiKey);

GetAuthenticatedUserResponse response = await client.Namespace.MgmtPublicServiceGetAuthenticatedUserAsync();

var user = response.User;

Console.WriteLine($"User ID: {user.Id}");
Console.WriteLine($"Name: {user.Name}");
```