using System.Collections.Generic;
using Jugs.Interfaces;

namespace Jugs.Models
{
  public class Burger : FoodItem, IPurchasable, ISize
  {
    public Burger(string name, int calories, int fat, int protien, int carbs, string meat, double price, IEnumerable<string> ingredients, string meatType, double basePrice, double size) : base(name, calories, fat, protien, carbs)
    {
      MeatType = meat;
      BasePrice = price;
      MeatType = meatType;
      SizeModifier = size;
      Ingredients = ingredients;
    }

    public string MeatType { get; set; }
    public double BasePrice { get; set; }
    public IEnumerable<string> Ingredients { get; set; }
    public double SizeModifier { get; set; }

    public double GetPrice(Size size)
    {
      return BasePrice + (SizeModifier * (int)size);
    }
  }

}