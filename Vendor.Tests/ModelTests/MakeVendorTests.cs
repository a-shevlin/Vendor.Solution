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
    public void GetList_ReadList_List()
    {
      List<MakeVendor> empty = new List<MakeVendor> {};
      List<MakeVendor> test = MakeVendor.GetList();
      CollectionAssert.AreEqual(test, empty);
    }

    [TestMethod]
    public void AddOrder_AddOrderToOrderList_List()
    {
      MakeVendor newVendor = new MakeVendor("name", "description");
      Order newOrder = new Order("test", "test", 0, "date");
      newVendor.AddOrder(newOrder);
      Assert.AreEqual(1, newVendor.Orders.Count);
    }

    [TestMethod]
    public void FindVendor_FindVendorById_Vendor()
    {
      MakeVendor newVendor = new MakeVendor("name", "description");
      List<MakeVendor> test = MakeVendor.GetList();
      Assert.AreEqual(MakeVendor.FindVendor(1), test[0]);
    }

    [TestMethod]
    public void RemoveVendor_DeleteVendorFromList_List()
    {
      MakeVendor newVendor = new MakeVendor("name", "description");
      MakeVendor newTwo = new MakeVendor("name", "description");
      List<MakeVendor> test = MakeVendor.GetList();
      List<MakeVendor> newList = new List<MakeVendor> {};
      MakeVendor.RemoveVendor(1);
      Assert.AreEqual(1, test.Count);
    }
  }
}