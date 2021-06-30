namespace api.Services
{
    public interface IPaymentService
    {
        bool Charge(double total, ICard card);
    }
}