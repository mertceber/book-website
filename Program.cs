using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using SUMMARIES.Data;  // BookDbContext'i import et
using Microsoft.Extensions.DependencyInjection;

namespace Book_Website
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureServices((context, services) =>
                    {
                        // Configuration nesnesine context üzerinden erişiyoruz
                        var connectionString = context.Configuration.GetConnectionString("DefaultConnection");

                        // DbContext'i servis konteynırına ekliyoruz
                        services.AddDbContext<BookDbContext>(options =>
                            options.UseSqlServer(connectionString)); // Connection string'i burada kullanıyoruz

                        // BookService'i DI konteynırına ekliyoruz
                        services.AddScoped<IBookService, BookService>(); // IBookService ve BookService ekleme
                    })
                    .UseStartup<Startup>();
                });
    }
}
