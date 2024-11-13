using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Stripe;

namespace BlazorStripe.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            StripeConfiguration.ApiKey = "sk_test_51MxBRxG2lcqXWYi2eX0voNB0IGhGEddskZfSIaWjge8xDbE0sz2ysL2db6jysNg05d2PvERB5M1GICcZ4ePxOppm00bQ4ngcEP";
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            await builder.Build().RunAsync();
        }
    }
}
