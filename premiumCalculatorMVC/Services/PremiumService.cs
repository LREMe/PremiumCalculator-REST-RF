namespace PremiumCalculator.MVC.Services
{
    public class PremiumService : IPremiumService
    {
        HttpClient _client;
        private readonly ILogger<PremiumService> _logger;
        private readonly IConfiguration _config;
        private string baseAddress;
        public PremiumService(HttpClient client, ILogger<PremiumService> logger, IConfiguration configuration)
        {
            _client = client;
            _logger = logger;
            _config = configuration;
            baseAddress = _config["WebAPIConfig:WebAddress"];

            _client.BaseAddress = new Uri(baseAddress);
        }

        public SelectList GetStates()
        {
            string baseStates = API.State.GetAllStates("StateList");
            return new SelectList(API.ApiTools.GetListFromWebApi(_client, baseStates, _logger, "stateId", "stateName"), "stateId", "stateName");
        }

        public SelectList GetPlans()
        {
            string basePlan = API.Plan.GetAllPlan("PlanList");
            return new SelectList(API.ApiTools.GetListFromWebApi(_client, basePlan, _logger, "planId", "planName"), "planId", "planName"); ;
        }

        public SelectList GetPeriods()
        {
            string basePeriod = API.Period.GetAllPeriod("PeriodList");
            return new SelectList(API.ApiTools.GetListFromWebApi(_client, basePeriod, _logger, "factor", "namePeriod"), "factor", "namePeriod");
        }

    }
}
