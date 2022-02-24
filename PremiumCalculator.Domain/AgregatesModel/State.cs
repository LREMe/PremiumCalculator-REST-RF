using System.ComponentModel.DataAnnotations;

namespace PremiumCalculator.Domain
{
    /// <summary>
    /// Class to map State
    /// </summary>
    public class State : IAggregateRoot
    {

        [Key]
        public string? StateId { get; set; }
        public string? StateName { get; set; }
    }
}
