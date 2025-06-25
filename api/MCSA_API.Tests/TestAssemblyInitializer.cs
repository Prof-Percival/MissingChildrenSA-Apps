using System.Text.Json;

namespace MCSA_API.Tests;

[TestClass]
public static class TestAssemblyInitializer
{
    [AssemblyInitialize]
    public static void Initialize(TestContext context)
    {
        const string secretsFile = "secrets.dev.json";

        if (!File.Exists(secretsFile))
        {
            Console.WriteLine($"Warning: {secretsFile} not found. No environment variables will be set.");
            return;
        }

        var json = File.ReadAllText(secretsFile);

        var secrets = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

        foreach (var kvp in secrets)
        {
            Environment.SetEnvironmentVariable(kvp.Key, kvp.Value);
        }

        Console.WriteLine("✅ secrets.dev.json loaded into environment.");
    }
}