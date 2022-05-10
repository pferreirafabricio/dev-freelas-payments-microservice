using System.Threading.Tasks;
using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services
{
    public interface IPaymentService
    {
        Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel);
    }
}
