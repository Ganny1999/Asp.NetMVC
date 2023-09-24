// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApp1
{
    public partial class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(builder =>
                {
                    builder.UseStartup<Startup>();
                });
    }
}