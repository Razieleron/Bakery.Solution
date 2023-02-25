using System.Collections.Generic;

namespace Products.Models
{
  public class Bread
  {
    public static int CalculateBreadCost(int input)
    {
      int costBread = 5;
      int numFreeBread = input / 3;
      int numPaidBread = input - numFreeBread;
      int breadTotal = 0;
      if (input == 0)
      {
        breadTotal = 0;
      }
      else
      {
      breadTotal = numPaidBread * costBread;
      }
      return breadTotal;
    }
  }
}
