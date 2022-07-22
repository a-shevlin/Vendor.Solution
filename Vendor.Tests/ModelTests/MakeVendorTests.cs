using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Vendor.Models;
using Vendor;

namespace Vendor.Tests
{
  [TestClass]
  public class MakeVendorTests : IDisposable
  {
    public void Dispose()
    {
      MakeVendor.ClearAll();
    }

    // Test methods go here
    [TestMethod]
    public void MakeVendor_CreateInstanceOfVendor_MakeVendor()
    {
      MakeVendor newVendor = new MakeVendor("name", "description");
      Assert.AreEqual(typeof(MakeVendor), newVendor.GetType());
    }

    [TestMethod]
    public void AddOrder_AddOrderToOrderList_List()
    {
      MakeVendor newVendor = new MakeVendor("name", "description");
      Order newOrder = new Order("test", "test", 0, "date");
      newVendor.AddOrder(newOrder);
      Assert.AreEqual(1, newVendor.Orders.Count);
    }
  }
}