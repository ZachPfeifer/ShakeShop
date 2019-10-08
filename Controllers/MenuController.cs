using System;
using System.Collections.Generic;
using System.Threading;
using Jugs.Models;
using Jugs.Services;

namespace Jugs.Controllers

{
  public class MenuController
  {
    private MenuService _menuService { get; set; } = new MenuService();
    private List<Shake> Cart { set; get; }
    // string input = Console.ReadLine();
    // Cart.AddCart(input);
    public void UserInput()
    {
      _menuService.GetShakes();
      Print();
      string choice = Console.ReadLine().ToUpper();
      Console.Clear();
      switch (choice)
      {
        case "Q":
          Environment.Exit(1);
          break;

        case "M":
          // Console.Clear();
          //FIXME push to main menu
          _menuService.GetShakes();
          Print();
          break;
        default:
          if (int.TryParse(choice, out int index))
          {
            _menuService.GetShakes(index - 1);
            Print();
            Console.ReadKey();
            Console.Clear();
            // string input = Console.ReadLine();
            // Cart.Add(input);
          }
          else
          {
            System.Console.WriteLine("Invalid Command!");

          }
          break;
      }
    }

    //FIXME Add Shake to Cart
    public void AddCart(Shake shake)
    {
      Cart.Add(shake);
    }

    private void Print()
    {
      Console.Clear();
      Console.WriteLine(@"
            
       ___         ___           ___           ___                    ___           ___           ___           ___           ___           ___     
      /\  \       /\__\         /\  \         /\  \                  /\  \         /\__\         /\  \         /\__\         /\  \         /\  \    
      \:\  \     /:/  /        /::\  \       /::\  \                /::\  \       /:/  /        /::\  \       /:/  /        /::\  \       /::\  \   
  ___ /::\__\   /:/  /        /:/\:\  \     /:/\ \  \              /:/\ \  \     /:/__/        /:/\:\  \     /:/__/        /:/\:\  \     /:/\ \  \  
 /\  /:/\/__/  /:/  /  ___   /:/  \:\  \   _\:\~\ \  \            _\:\~\ \  \   /::\  \ ___   /::\~\:\  \   /::\__\____   /::\~\:\  \   _\:\~\ \  \ 
 \:\/:/  /    /:/__/  /\__\ /:/__/_\:\__\ /\ \:\ \ \__\          /\ \:\ \ \__\ /:/\:\  /\__\ /:/\:\ \:\__\ /:/\:::::\__\ /:/\:\ \:\__\ /\ \:\ \ \__\
  \::/  /     \:\  \ /:/  / \:\  /\ \/__/ \:\ \:\ \/__/          \:\ \:\ \/__/ \/__\:\/:/  / \/__\:\/:/  / \/_|:|~~|~    \:\~\:\ \/__/ \:\ \:\ \/__/
   \/__/       \:\  /:/  /   \:\ \:\__\    \:\ \:\__\             \:\ \:\__\        \::/  /       \::/  /     |:|  |      \:\ \:\__\    \:\ \:\__\  
                \:\/:/  /     \:\/:/  /     \:\/:/  /              \:\/:/  /        /:/  /        /:/  /      |:|  |       \:\ \/__/     \:\/:/  /  
                 \::/  /       \::/  /       \::/  /                \::/  /        /:/  /        /:/  /       |:|  |        \:\__\        \::/  /   
                  \/__/         \/__/         \/__/                  \/__/         \/__/         \/__/         \|__|         \/__/         \/__/    

            ");
      foreach (string message in _menuService.Messages)
      {
        System.Console.WriteLine(message);
      }
      _menuService.Messages.Clear();
      System.Console.WriteLine();
    }


  }
}