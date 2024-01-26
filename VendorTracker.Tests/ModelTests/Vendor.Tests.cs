using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    
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
    
    [TestMethod]
    public void SetVendorDescription_SetsVendorDescription_Void()
    {
      string description = "Orders every tuesday";
      Vendor newVendor = new Vendor("bread", description);
      string updatedDescription = "Orders every wednesday";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;
      Assert.AreEqual(updatedDescription, result);
    }
    
    [TestMethod]
    public void GetVendorID_ReturnsVendorID_Int()
    {
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {

      Vendor newVendor1 = new Vendor("name01", "description01");
      Vendor newVendor2 = new Vendor("name02", "description02");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}