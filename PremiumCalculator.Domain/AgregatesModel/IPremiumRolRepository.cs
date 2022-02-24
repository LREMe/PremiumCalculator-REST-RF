namespace PremiumCalculator.Domain.AgregatesModel
{
    public interface IPremiumRolRepository : IRepository<PremiumRol>
    {

        Task<IList<PremiumRolResponse>> GetAsync(PremiumRol q);
    }
}
