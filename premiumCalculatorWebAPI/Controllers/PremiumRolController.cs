using System.Globalization;

namespace PremiumCalculator.API.Controllers
{
    [ApiController]
    public class PremiumRolController : ControllerBase
    {
        private readonly IPremiumRolRepository _premiumRolRepository;
        private readonly ILogger<PremiumRolController> logger;

        public PremiumRolController(IPremiumRolRepository premiumRolRepository, ILogger<PremiumRolController> logger)
        {

            this._premiumRolRepository = premiumRolRepository;
            this.logger = logger;

        }

        [HttpPut]
        [Route("GetPremium")]
        public async Task<IList<PremiumRolResponse>> GetPremium([FromBody] PremiumQ q)
        {

            string month = "";
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - q.DoB.Year;
            //not the same agen
            if (age != q.Age)
            {
                return (IList<PremiumRolResponse>)Results.NotFound();
            }
            //get the month
            CultureInfo ci = new CultureInfo("en-US");
            month = q.DoB.ToString("MMMM", ci);


            PremiumRol p = new PremiumRol();
            p.Age = age.ToString();
            p.MonthOfBirth = month;
            p.Plan = q.Plan;
            p.State = q.State;


            try
            {

                logger.LogInformation("Premium success!");
                return await _premiumRolRepository.GetAsync(p);
            }
            catch (Exception e)
            {
                logger.LogError(e, "Premium Exception");
                return (IList<PremiumRolResponse>)Results.NotFound();
            }


        }



    }
}
