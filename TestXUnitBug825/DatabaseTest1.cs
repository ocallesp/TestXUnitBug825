using System;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

[Collection("Database collection")]
public class DatabaseTest1
{
    private readonly ITestOutputHelper _output;
    DatabaseFixture _fixture;

    public DatabaseTest1(DatabaseFixture fixture, ITestOutputHelper output)
    {
        _fixture = fixture;
        _output = output;
    }

    [Fact]
    public void Test1()
    {
        _output.WriteLine("Running Collection Test1");
        _output.WriteLine("Current Time: {0:HH:mm:ss.fff}", DateTime.Now);
        _output.WriteLine("Database Initialization Count: {0}", DatabaseFixture.InitializationCount);

        // Simulate a delay to observe order
        Thread.Sleep(60000);

        Assert.NotNull(_fixture.Database);
        Assert.Equal("Database Initialized", _fixture.Database);
    }
}