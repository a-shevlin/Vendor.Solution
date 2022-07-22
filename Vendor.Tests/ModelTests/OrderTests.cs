using Microsoft.VisualStudio.TestTools.UnitTesting;
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
  }
}