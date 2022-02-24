namespace PremiumCalculator.Domain.AgregatesModel
{
    public record PremiumRolResponse
    {
        public string? carrier { get; set; }
        public double premium { get; set; }
    }
}
