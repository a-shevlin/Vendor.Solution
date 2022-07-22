using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vendor.Models;
using Vendor;

namespace Vendor.Tests
{
  [TestClass]
  public class OrderTests
  {
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
      foreach (var item in empty)
      {
        Console.WriteLine(item);
      }
      foreach (var item in test)
      {
        Console.WriteLine(item);
      }
      Assert.AreEqual(test, empty);
    }
  }
}