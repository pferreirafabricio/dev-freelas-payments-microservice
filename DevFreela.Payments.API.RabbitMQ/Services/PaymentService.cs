using System.Threading.Tasks;
using DevFreela.Payments.API.RabbitMQ.Models;

namespace DevFreela.Payments.API.RabbitMQ.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
        {
            return Task.FromResult(true);
        }
    }
}
