using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicRestaurant.Models;
using System.Collections.Generic;
using System;

namespace BasicRestaurant.Tests
{
  [TestClass]
  public class BusinessesTests : IDisposable
  {
    public void Dispose()
    {
      // Business.ClearAll();
    }

    [TestMethod]
    public void CreateBusiness_InstantiateBusiness_Business()
    {
      string name = "PkillinIT";
      Business newBusiness = new Business(name);
      Assert.AreEqual(name, newBusiness.Name);
      Assert.AreEqual(0, newBusiness.Id);
    }
  }
}