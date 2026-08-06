using EFCwithWebAPI.Dbcontext;
using EFCwithWebAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace EFCwithWebAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Host for DI + EF Core
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    // Register EF Core with SQL Server
                    services.AddDbContext<SentenceDbContext>(options =>
                        options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SentencesDb;Trusted_Connection=True;"));

                    // Register services
                    services.AddScoped<ISentenceService, SentenceService>();
                })
                .Build();

            // Resolve service from DI
            using var scope = host.Services.CreateScope();
            var service = scope.ServiceProvider.GetRequiredService<ISentenceService>();

            // Example CRUD operations
            service.AddSentence(new Models.SentenceHolder { Sentence = "Hello from Console App!" });

            var sentences = service.GetAll();
            foreach (var s in sentences)
            {
                Console.WriteLine($"{s.Id} - {s.Sentence}");
            }
        }
    }
}
