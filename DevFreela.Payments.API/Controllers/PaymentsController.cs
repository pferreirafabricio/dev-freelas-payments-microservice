using System.Threading.Tasks;
using DevFreela.Payments.API.Models;
using DevFreela.Payments.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Payments.API.Controllers
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
