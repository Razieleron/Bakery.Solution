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
      int breadTotal = numPaidBread * costBread;
      return breadTotal;
      }
    }
  }
