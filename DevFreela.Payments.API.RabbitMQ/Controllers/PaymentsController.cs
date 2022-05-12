using System.Threading.Tasks;
using DevFreela.Payments.API.RabbitMQ.Models;
using DevFreela.Payments.API.RabbitMQ.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Payments.API.RabbitMQ.Controllers
{
    [ApiController]
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {
        public readonly IPaymentService _paymentService;
        
        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Pay([FromBody] PaymentInfoInputModel paymentInfo)
        {
            var result = await _paymentService.Process(paymentInfo);

            if (!result)
                return BadRequest();

            return NoContent();
        }
    }
}
