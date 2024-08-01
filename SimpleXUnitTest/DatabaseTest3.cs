using System;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

public class DatabaseTest3
{
    private readonly ITestOutputHelper _output;
    private readonly DatabaseFixture _fixture;

    public DatabaseTest3(ITestOutputHelper output)
    {
        _fixture = new DatabaseFixture();
        _output = output;
    }

    [Fact]
    public void Test3()
    {
        _output.WriteLine("Running Simple Test3");
        _output.WriteLine("Current Time: {0:HH:mm:ss.fff}", DateTime.Now);
        _output.WriteLine("Database Initialization Count: {0}", 1); // Since this is independent

        // Simulate a longer delay to observe order
        Thread.Sleep(60000);

        Assert.NotNull(_fixture.Database);
        Assert.Equal("Database Initialized", _fixture.Database);

        _fixture.Dispose();  // Manually dispose the fixture
    }
}
