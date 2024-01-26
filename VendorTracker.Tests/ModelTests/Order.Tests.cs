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
      Order newOrder = new Order("Test Title");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitleValue_String()
    {
      string title = "bread";
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
   public void SetTitle_SetsTitleValue_Void()
   {
     string title = "bread";
     Order newOrder = new Order(title);
     string updatedTitle = "milk";
     newOrder.Title = updatedTitle;
     string result = newOrder.Title;
     Assert.AreEqual(updatedTitle, result);
   }
  }
}