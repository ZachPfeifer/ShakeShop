using System;
using System.Collections.Generic;
using Jugs.Models;

namespace Jugs.Services
{
  public class MenuService
  {
    public List<Shake> Shakes { get; private set; }
    private List<Shake> Cart { set; get; }
    // Shake myCart = new Shake()

    public List<string> Messages { get; set; }



    public void Setup()
    {
      //MilkShake
      Shake shake1 = new Shake("Chacolate Shake", 2, 2, 2, 2, new string[] { "Chacolate Stuff", "Milk Stuff", "Shake Stuff" }, "Milk Shake", 3, 2);
      Shake shake2 = new Shake("Vanilla Shake", 2, 2, 2, 2, new string[] { "Vanilla Stuff", "Milk Stuff", "Shake Stuff" }, "Milk Shake", 3, 2);
      //Molt
      Shake molt1 = new Shake("Chacolate Shake", 2, 2, 2, 2, new string[] { "Chacolate Stuff", "Molt Stuff", "Molt Stuff" }, "Molt Shake", 4, 3);
      Shake molt2 = new Shake("Vanilla Shake", 2, 2, 2, 2, new string[] { "Vanilla Stuff", "Molt Stuff", "Molt Stuff" }, "Molt Shake", 4, 3);
      //Floats
      Shake float1 = new Shake("Rootbeer Float", 2, 2, 2, 2, new string[] { "Rootbeer", "Vanilla Ice Cream", "Milk Stuff" }, "Rootbeer Float", 4, 3);
      Shake float2 = new Shake("Sprite Float", 2, 2, 2, 2, new string[] { "Sprite", "Sherbert Ice Cream" }, "Sprite Float", 4, 3);




      //Added Shakes
      Shakes.AddRange(new Shake[] { shake1, shake2, molt1, molt2, float1, float2 });

      //FIXME Input from User to Cart?????
      // string input = Console.ReadLine();
      // Cart.AddCart(input);
    }
    public void GetShakes(int index)
    {
      if (index < Shakes.Count && index > -1)
      {
        Shake shake = Shakes[index];
        Messages.Add(shake.GetTemplate());
        if (shake is Shake)
        {
          Shake shakeMenu = (Shake)shake;
        }
      }
      else
      {
        Messages.Add("Invalid Choice... Find a Real Shake");
      }
    }

    public void GetShakes()
    {
      Messages.Add("Shakes on the Menu");
      for (int i = 0; i < Shakes.Count; i++)
      {
        Shake s = Shakes[i];
        Messages.Add($"{i + 1}:{s.ShakeType} - {s.Name} ");
      }
      Messages.Add("Type a (#) to see Details, (M)ain Menu, or (Q)uit");
    }

    //FIXME Adding a Shake to Cart
    // public void CartItem()
    // {
    //   // Shake selectShake = GetShakes(int index);
    //   Shake selectshake = Shake[input];
    //   if (selectShake == null)
    //   {
    //     Console.Clear();
    //     Console.WriteLine("Not a Shake on the Menu");
    //   }
    //   else
    //   {
    //     Cart.Add(selectShake);
    //     Console.Clear();
    //     Console.WriteLine("Added Shake to Cart");
    //     Setup();
    //   }
    // }


    // public void AddCart(Shake shake)
    // {
    //   Cart.Add(shake);
    // }



    public MenuService()
    {
      Messages = new List<string>();
      Shakes = new List<Shake>();
      Cart = new List<Shake>();

      Setup();
    }
  }
}