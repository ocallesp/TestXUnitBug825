using System;

public class DatabaseFixture : IDisposable
{
    public string Database { get; private set; }
    private static int initializationCount = 0;

    public DatabaseFixture()
    {
        // Simulate creating a database that can only be initialized once
        initializationCount++;
        Console.WriteLine($"Initializing Database (Count: {initializationCount})");
        Database = "Database Initialized";
    }

    public void Dispose()
    {
        // Simulate tearing down the database
        Console.WriteLine("Disposing Database");
        Database = null;
    }
}
