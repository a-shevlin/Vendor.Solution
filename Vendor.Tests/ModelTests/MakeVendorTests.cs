using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor.Models;
using Vendor;

namespace Vendor.Tests
{
  [TestClass]
  public class MakeVendorTests
  {
    // Test methods go here
    [TestMethod]
    public void MakeVendor_CreateInstanceOfVendor_ReturnValue()
    {
      MakeVendor newVendor = new MakeVendor("name", "description");
      Assert.AreEqual(typeof(MakeVendor), newVendor.GetType());
    }
  }
}