namespace EigenAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static EigenAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("EIGENAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("EIGENAI_API_KEY environment variable is not found.");

        var client = new EigenAIClient(apiKey);
        
        return client;
    }
}
