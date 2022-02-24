namespace PremiumCalculator.Infraestructure.Repositories
{
    public class PlanRepository : IPlanRepository
    {
        private readonly PremiumRolDbContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public PlanRepository(PremiumRolDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IList<Plan>> GetAsync()
        {
            return await _context.Plans.ToListAsync();
        }
    }
}
