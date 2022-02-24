namespace PremiumCalculator.Domain.AgregatesModel
{
    public interface IPlanRepository : IRepository<Plan>
    {

        Task<IList<Plan>> GetAsync();

    }
}
