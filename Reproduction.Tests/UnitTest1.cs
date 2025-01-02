namespace Reproduction.Tests;

internal sealed class PdfProcessorTests
{
    private string _someMemberVariable = "ARandomValue";

    [OneTimeSetUp]
    public async Task OneTimeSetup()
    {
        // To demonstrate the usage of async code. In our real project we're spinning up a container here using TestContainers.
        _someMemberVariable = await GetSomeValueAsync();
    }

    private async Task<string> GetSomeValueAsync()
    {
        await Task.Delay(100);
        return "ANewValue+" + new Random().Next();
    }

    [SetUp]
    public void Setup()
    {
        // Setup isn't relevant to this issue, I don't think, so this is a no-op.
    }

    [OneTimeTearDown]
    public async Task OneTimeTeardown()
    {
        // Again, just demonstrating the usage of an async method here.
        _someMemberVariable = await GetSomeValueAsync();
    }

    [Test]
    public void ADummyTest()
    {
        // The test contents don't matter in this case.
        Assert.Pass();
    }
}
