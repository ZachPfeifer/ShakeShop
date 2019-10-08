using Jugs.Interfaces;

namespace Jugs.Models
{
  public abstract class Merchandise : IPurchasable
  {
    public double BasePrice { get; set; }
  }
}