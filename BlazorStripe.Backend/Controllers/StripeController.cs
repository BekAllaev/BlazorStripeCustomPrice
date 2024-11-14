using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorStripe.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripeController : ControllerBase
    {
        // GET: api/<StripeController>
        [HttpGet]
        public async Task<string> GetCheckoutUrl(int price, string orderId, string domain)
        {
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
            {
                new()
                {
                    PriceData = new()
                    {
                        UnitAmount = Convert.ToInt16(price) * 100, // цена в центах (например, £49 = 4900)
                        Currency = "usd",
                        ProductData = new()
                        {
                            Name = $"Order#{orderId??"111"}",
                        }
                    },
                    Quantity = 1,
                },
            },
                Mode = "payment",
                SuccessUrl = domain + "/OrderComplete",
                CancelUrl = domain + "/OrderAbandoned"
            };
            var service = new SessionService();
            var session = await service.CreateAsync(options);

            return session.Url;
        }
    }
}
