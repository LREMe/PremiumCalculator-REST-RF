using System.Collections;

namespace PremiumCalculator.Domain.AgregatesModel
{
    public interface IStateRepository : IRepository<State>
    {

        Task<IList> GetAsync();

    }
}
