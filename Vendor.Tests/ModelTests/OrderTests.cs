using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vendor.Models;
using Vendor;

namespace Vendor.Tests
{
  
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    // Test methods go here
    [TestMethod]
    public void Order_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 0, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetList_ReadList_List()
    {
      List<Order> empty = new List<Order> {};
      List<Order> test = Order.GetList();
      CollectionAssert.AreEqual(test, empty);
    }
  }
}