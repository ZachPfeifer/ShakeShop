using Jugs.Interfaces;

namespace Jugs.Models
{
  public class FoodMerch : Merchandise, IConsumable
  {
    public string Vender { get; set; }
    public int Calories { get; set; }
    public int Fat { get; set; }
    public int Protien { get; set; }
    public int Carbs { get; set; }
  }
}