



namespace PremiumCalculator.API.Controllers
{
    public class StateController : ControllerBase
    {

        private readonly IStateRepository _stateRepository;
        private readonly ILogger<StateController> logger;

        public StateController(IStateRepository planRepository, ILogger<StateController> logger)
        {

            this._stateRepository = planRepository;
            this.logger = logger;

        }


        [HttpGet]
        [Route("StateList")]
        public async Task<IList> PlanList()
        {
            return await _stateRepository.GetAsync();
        }
    }
}
