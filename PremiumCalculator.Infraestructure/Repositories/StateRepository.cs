using System.Collections;

namespace PremiumCalculator.Infraestructure.Repositories
{
    public class StateRepository : IStateRepository
    {
        private readonly PremiumRolDbContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public StateRepository(PremiumRolDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IList> GetAsync()
        {

            var select = from state in _context.States
                         orderby state.StateName ascending
                         select new
                         {
                             state.StateId,
                             state.StateName
                         };

            return await select.ToListAsync();
        }
    }
}
