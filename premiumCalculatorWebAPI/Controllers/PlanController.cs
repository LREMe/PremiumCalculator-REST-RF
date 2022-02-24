namespace PremiumCalculator.API.Controllers
{
    public class PlanController : ControllerBase
    {

        private readonly IPlanRepository _planRepository;
        private readonly ILogger<PlanController> logger;

        public PlanController(IPlanRepository planRepository, ILogger<PlanController> logger)
        {

            this._planRepository = planRepository;
            this.logger = logger;

        }


        [HttpGet]
        [Route("PlanList")]
        public async Task<IList<Plan>> PlanList()
        {
            return await _planRepository.GetAsync();
        }
    }
}
