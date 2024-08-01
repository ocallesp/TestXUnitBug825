using System;
using Xunit;

public class DatabaseFixture : IDisposable
{
    public string Database { get; private set; }
    public static int InitializationCount = 0;

    public DatabaseFixture()
    {
        // Simulate creating a database that can only be initialized once
        InitializationCount++;
        Database = "Database Initialized";
    }

    public void Dispose()
    {
        // Simulate tearing down the database
        Database = null;
    }
}
