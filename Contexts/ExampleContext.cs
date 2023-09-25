

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;

namespace Contexts;

public class ExampleContext: DbContext
{
    public DbSet<Example> Examples { get; set; }

    public string ConnectionString { get; init;}

    public ExampleContext()
    {
        IConfigurationBuilder builder = new ConfigurationBuilder();
        builder.AddUserSecrets<Program>();
        builder.AddJsonFile("appsettings.json");
        
        IConfiguration config = builder.Build();
        ConnectionString = config["WebApiDatabase"]!;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(ConnectionString);
    }
}
