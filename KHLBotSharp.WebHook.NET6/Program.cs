using KHLBotSharp.Core.BotHost;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace KHLBotSharp.WebHook.NET6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Welcome.Print();
            CreateHostBuilder(args).Build().RunBot();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    });
        }
    }
}