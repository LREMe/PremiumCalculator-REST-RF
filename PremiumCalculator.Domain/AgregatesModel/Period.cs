using System.ComponentModel.DataAnnotations;

namespace PremiumCalculator.Domain
{
    /// <summary>
    /// Class to map Period
    /// </summary>
    public class Period : IAggregateRoot
    {

        [Key]
        public string? IdPeriod { get; set; }
        public string? NamePeriod { get; set; }
        public int Factor { get; set; }
    }
}
