using Jugs.Interfaces;

namespace Jugs.Models
{
  public class FoodItem : IConsumable
  {
    public string Name { get; set; }
    public int Calories { get; set; }
    public int Fat { get; set; }
    public int Protien { get; set; }
    public int Carbs { get; set; }
    public FoodItem(string name, int calories, int fat, int protien, int carbs) //ABSTRACT??
    {
      this.Name = name;
      this.Calories = calories;
      this.Fat = fat;
      this.Protien = protien;
      this.Carbs = carbs;

    }
  }
}