using System.Collections.Generic;
using Jugs.Interfaces;

namespace Jugs.Models
{
  public class Shake : FoodItem, IPurchasable, ISize
  {
    public Shake(string name, int calories, int fat, int protien, int carbs, IEnumerable<string> ingredients, string shakeType, double basePrice, double size) : base(name, calories, fat, protien, carbs)
    {
      ShakeType = shakeType;
      BasePrice = basePrice;
      SizeModifier = size;
      Ingredients = ingredients;

    }

    public string ShakeType { get; set; }
    public double BasePrice { get; set; }
    public IEnumerable<string> Ingredients { get; set; }
    public double SizeModifier { get; set; }


    public string GetTemplate()
    {
      // string ingredients = "";
      // Ingredients.ForEach(i => ingredients += $"\n{i}");

      // var ingredients = new Ingredients();
      // foreach (Ingredients ingredients in ingredients)

      // People peopleList = new People(peopleArray);
      // foreach (Person p in peopleList)
      //   Console.WriteLine(p.firstName + " " + p.lastName);

      // Shake ingredients = new Shake.Ingredients;
      // foreach (Ingredients  in Shake(Ingredients))
      // {

      // }



      // Ingredients: {Ingredients}
      return $@"
        {Name}
  Type of Shake: {ShakeType}
  Nutrition Values: 
    Calories:{Calories}, 
    Fats: {Fat}, 
    Protien: {Protien},
    Carbs: {Carbs}

  Price: {BasePrice:c}
  Sizes:

Type a (#) to add to Cart, (M)ain Menu, or (Q)uit
  ";
      //  Small:{Size.small:c}   Medium:{Size.medium:c}   Large:{Size.large:c}   
      //          X-Large:{Size.xlarge:c}     Supersize:{Size.supersize:c}

      // Press the (#)Size you want to add to Cart, (M)enu to get back to main Menu
    }



    public double GetPrice(Size size)
    {
      return BasePrice + (SizeModifier * (int)size);
    }
  }

}