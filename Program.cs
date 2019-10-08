using System;
using Jugs.Controllers;

namespace Jugs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      MenuController mc = new MenuController();
      while (true)
      {
        mc.UserInput();
      }
    }
  }
}
