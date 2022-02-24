namespace PremiumCalculator.Infraestructure.Repositories
{
    public class PeriodRepository : IPeriodRepository
    {
        private readonly PremiumRolDbContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public PeriodRepository(PremiumRolDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IList<Period>> GetAsync()
        {
            return await _context.Periods.ToListAsync();
        }

    }
}
