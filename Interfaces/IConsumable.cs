namespace Jugs.Interfaces
{
  public interface IConsumable
  {
    int Calories { get; set; }
    int Fat { get; set; }
    int Protien { get; set; }
    int Carbs { get; set; }
  }
}