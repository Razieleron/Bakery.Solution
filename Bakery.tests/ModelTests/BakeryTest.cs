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
    //public void NameOfMethod_WhatTheTestDoes_DesiredOutcome()
    //arrange - get all your variables
    //act - do what you're gonna do with the variables
    //assert - make sure it does what you want it to

  }

}