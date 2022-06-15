using System;
using Autofac.Extensions.DependencyInjection;

namespace sampleAccessNycProject.Startup
{
    public class WebApplication
    {
        // using example from
        // https://medium.com/dotnet-hub/use-autofac-ioc-container-in-dotnet-or-aspnetcore-autofac-dependency-injection-netcore-ffad19d87163
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

