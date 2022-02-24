namespace PremiumCalculator.API.Controllers
{
    public class PeriodController : ControllerBase
    {

        private readonly IPeriodRepository _periodRepository;
        private readonly ILogger<PeriodController> logger;

        public PeriodController(IPeriodRepository periodRepository, ILogger<PeriodController> logger)
        {

            this._periodRepository = periodRepository;
            this.logger = logger;

        }


        [HttpGet]
        [Route("PeriodList")]
        public async Task<IList<Period>> PeriodList()
        {
            return await _periodRepository.GetAsync();
        }
    }
}
