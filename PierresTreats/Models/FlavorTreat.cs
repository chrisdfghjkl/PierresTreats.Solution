namespace PierresTreats.Models
{
  public class FlavorTreat
  {
    public int FlavorTreatId { get; set; }
    public int TreatId { get; set; }
    public int FlavorId { get; set; }
    public virtual Treat Treat {get; set; }
    public virtual Flavor Flavor { get; set; }
  }
}