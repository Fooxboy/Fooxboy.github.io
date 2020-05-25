using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using FooxboySite.Services;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace FooxboySite
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddSingleton<ProjectLoaderService>();
            builder.Services.AddSingleton<ConfigLoaderService>();
            await builder.Build().RunAsync();
        }
    }
}
