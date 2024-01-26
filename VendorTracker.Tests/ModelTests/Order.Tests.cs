using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Title", "Test Description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitleValue_String()
    {
      string title = "bread order";
      Order newOrder = new Order(title, "12 orders of bread");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
   public void SetTitle_SetsTitleValue_Void()
   {
     string title = "bread";
     Order newOrder = new Order(title, "12 orders of bread");
     string updatedTitle = "pastry";
     newOrder.Title = updatedTitle;
     string result = newOrder.Title;
     Assert.AreEqual(updatedTitle, result);
   }
    [TestMethod]
    public void GetDescription_ReturnsDescriptionValue_String()
    {
      string description = "12 orders of bread";
      Order newOrder = new Order("bread", description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}