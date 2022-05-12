using System.Threading.Tasks;
using DevFreela.Payments.API.RabbitMQ.Models;

namespace DevFreela.Payments.API.RabbitMQ.Services
{
    public interface IPaymentService
    {
        Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel);
    }
}
