namespace PremiumCalculator.Domain.AgregatesModel
{
    public interface IPeriodRepository
    {

        Task<IList<Period>> GetAsync();
    }
}
