using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test Vendor", "Test Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "Test Description");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void SetName_SetsVendorName_Void()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "Test Description");
      string updatedName = "Updated Vendor";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(updatedName, result);
    }
    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescriptionValue_String()
    {
      string description = "Orders every tuesday";
      Vendor newVendor = new Vendor("bread", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
  
  }
}