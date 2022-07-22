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

    [TestMethod]
    public void FindOrder_FindOrderById_Order()
    {
      Order newOrder = new Order("test", "test", 0, "date");
      List<Order> test = Order.GetList();
      Assert.AreEqual(Order.FindOrder(1), test[0]);
    }

    [TestMethod]
    public void RemoveOrder_DeleteOrderFromList_List()
    {
      Order newOrder = new Order("test", "test", 0, "date");
      Order newTwo = new Order("test", "test", 0, "date");
      List<Order> test = Order.GetList();
      List<Order> newList = new List<Order> {};
      Order.RemoveOrder(1);
      Assert.AreEqual(1, test.Count);
    }
  }
}