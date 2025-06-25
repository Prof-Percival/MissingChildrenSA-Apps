namespace MCSA_API.Tests;

public static class Secrets
{
    public static string TestUsername =>
        Environment.GetEnvironmentVariable("MCSA_TEST_USER")
        ?? throw new InvalidOperationException("Environment variable MCSA_TEST_USER is not set.");

    public static string TestPassword =>
        Environment.GetEnvironmentVariable("MCSA_TEST_PASSWORD")
        ?? throw new InvalidOperationException("Environment variable MCSA_TEST_PASSWORD is not set.");
}