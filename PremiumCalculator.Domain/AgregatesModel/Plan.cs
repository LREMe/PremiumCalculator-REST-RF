using System.ComponentModel.DataAnnotations;

namespace PremiumCalculator.Domain
{
    /// <summary>
    /// Class to map Plan
    /// </summary>
    public class Plan : IAggregateRoot
    {
        [Key]
        public string? PlanId { get; set; }
        public string? PlanName { get; set; }
    }
}
