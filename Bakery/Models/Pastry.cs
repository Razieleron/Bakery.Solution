using System.Collections.Generic;

namespace Products.Models
{
  public class Pastry
  {
    public static int CalculatePastryCost(int input)
    {
      int costPastry = 2;
      int numFreePastry = input / 4;
      int numPaidPastry = input - numFreePastry;
      int pastryTotal = 0;
      if (input == 0)
      {
        pastryTotal = 0;
      }
      else
      {
        pastryTotal = numPaidPastry * costPastry;
      }
      return pastryTotal;
    }
  }
}