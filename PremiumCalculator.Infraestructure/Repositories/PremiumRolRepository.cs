namespace PremiumCalculator.Infraestructure.Repositories
{
    public class PremiumRolRepository : IPremiumRolRepository
    {

        private readonly PremiumRolDbContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }


        public PremiumRolRepository(PremiumRolDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IList<PremiumRolResponse>> GetAsync(PremiumRol q)
        {

            var select = from premiumRol in _context.PremiumRols
                         where (premiumRol.MonthOfBirth.Equals(q.MonthOfBirth) || premiumRol.MonthOfBirth.Equals("*"))
                          && (premiumRol.State.Equals(q.State) || premiumRol.State.Equals("*"))
                          && (premiumRol.Plan.Contains(q.Plan) || premiumRol.Plan.Equals("*"))
                          && (
                                  (
                                  premiumRol.Age.Contains("-")
                                  &&
                                  String.Compare(q.Age.ToString(), premiumRol.Age.Substring(0, premiumRol.Age.IndexOf("-"))) >= 0
                                  &&
                                  String.Compare(q.Age.ToString(), premiumRol.Age.Substring(premiumRol.Age.IndexOf("-") + 1)) <= 0
                                  )
                                  ||
                                  (
                                  premiumRol.Age.EndsWith("+")
                                  &&
                                  String.Compare(q.Age.ToString(), premiumRol.Age.Substring(0, premiumRol.Age.IndexOf("+"))) >= 0
                                  )
                          )
                         select new PremiumRolResponse
                         {
                             carrier = premiumRol.Carrier,
                             premium = premiumRol.Premium
                         };

            return await select.ToListAsync();
            // return Results.Ok(await select.ToListAsync());

        }
    }
}


