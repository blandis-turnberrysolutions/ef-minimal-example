using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ef_minimal_example.console;
using ef_minimal_example.data;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true)
    .Build();
var connectionString = configuration.GetConnectionString("AccuPrecisionDBContext");

var services = new ServiceCollection();
services.AddDbContext<AccuPrecisionDbContext>(options => options
    .UseMySQL(connectionString)
    .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
);
services.AddKeyedSingleton<ICommand, DefaultCommand>("default");

var command = args.FirstOrDefault("default");
var serviceProvider = services.BuildServiceProvider();

var commandService = serviceProvider.GetKeyedService<ICommand>(command);
if (commandService != null)
{
    Console.WriteLine("Starting");
    await commandService.Execute();
    Console.WriteLine("Finished");
}
else
{
    Console.WriteLine($"Command `{command}` not found");
}

