namespace PremiumCalculator.MVC.Services
{
    public interface IPremiumService
    {

        SelectList GetStates();
        SelectList GetPlans();
        SelectList GetPeriods();
    }
}
