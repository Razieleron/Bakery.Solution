using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void CalculateBreadCost_CalculatesCostOf1_ReturnsBreadCost()
    {
      int input = 1;
      Assert.AreEqual(5, Bread.CalculateBreadCost(input));
    }
    [TestMethod]
    public void CalculateBreadCost_CalculatesCostOf2_ReturnsBreadCost()
    {
      int input = 2;
      Assert.AreEqual(10, Bread.CalculateBreadCost(input));
    }
    [TestMethod]
    public void CalculateBreadCost_CalculatesCostOf3_ReturnsBreadCost()
    {
      int input = 3;
      Assert.AreEqual(10, Bread.CalculateBreadCost(input));
    }
    [TestMethod]
    public void CalculateBreadCost_CalculatesCostOf0_ReturnsBreadCost()
    {
      int input = 0;
      Assert.AreEqual(0, Bread.CalculateBreadCost(input));
    }
    //---------------------------------------------------------------------//
        [TestMethod]
    public void CalculatePastryCost_CalculatesCostOf1_ReturnsPastryCost()
    {
      int input = 1;
      Assert.AreEqual(2, Pastry.CalculatePastryCost(input));
    }
    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOf2_ReturnsPastryCost()
    {
      int input = 2;
      Assert.AreEqual(4, Pastry.CalculatePastryCost(input));
    }
    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOf3_ReturnsPastryCost()
    {
      int input = 3;
      Assert.AreEqual(6, Pastry.CalculatePastryCost(input));
    }
    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOf4_ReturnsPastryCost()
    {
      int input = 4;
      Assert.AreEqual(6, Pastry.CalculatePastryCost(input));
    }
    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOf0_ReturnsPastryCost()
    {
      int input = 0;
      Assert.AreEqual(0, Pastry.CalculatePastryCost(input));
    }
  }

}