using System;
using Products.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the Bakery!  We've got everything you could ever want!  (Just kidding, we have bread and pastries)  ");
      Console.WriteLine();
      Console.WriteLine("The prices are as follows");
      Console.WriteLine();
      Console.WriteLine("For Loaves of Bread, the price is 5 dollars a loaf - but we have a special!");
      Console.WriteLine("If you buy 2 loaves, you get the third free!   So 3 loaves would equal 10 dollars");
      Console.WriteLine();
      Console.WriteLine("For Pastries, the price is 2 dollars per pastry.  We have a deal on pastries as well!");
      Console.WriteLine("If you purchase 3 loaves, you get the 4th free!  So 4 pastries would equal 6 dollars");
      Console.WriteLine();
      Console.WriteLine("How many loaves would you like?");
      int breadOrder;
      while (!int.TryParse(Console.ReadLine(), out breadOrder))
        {
          Console.WriteLine("Invalid input. Please enter a number.");
        }
      Console.WriteLine($"Your subtotal for your Bread is {Bread.CalculateBreadCost(breadOrder)}");
      Console.WriteLine("How many pastries would you like?");
      int pastryOrder;
      while (!int.TryParse(Console.ReadLine(), out pastryOrder))
        {
          Console.WriteLine("Invalid input. Please enter a number.");
        }
      Console.WriteLine($"Your subtotal for your Pastry(ies) is {Pastry.CalculatePastryCost(pastryOrder)}");
      Console.WriteLine();
      Console.WriteLine($"That Brings your total to {Bread.CalculateBreadCost(breadOrder) + Pastry.CalculatePastryCost(pastryOrder)} dollars.");
    }
  }
}