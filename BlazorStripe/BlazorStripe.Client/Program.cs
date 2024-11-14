using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorStripe.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped(sp => new HttpClient 
            {
                BaseAddress = new Uri(builder.Configuration["BackendURL"]) 
            });

            await builder.Build().RunAsync();
        }
    }
}
