
using Stripe;

namespace BlazorStripe.Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StripeConfiguration.ApiKey = "sk_test_51MxBRxG2lcqXWYi2eX0voNB0IGhGEddskZfSIaWjge8xDbE0sz2ysL2db6jysNg05d2PvERB5M1GICcZ4ePxOppm00bQ4ngcEP";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
