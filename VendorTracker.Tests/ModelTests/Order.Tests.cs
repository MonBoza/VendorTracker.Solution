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
      Order newOrder = new Order("Test Title", "Test Description", 5, "1/26/2024");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitleValue_String()
    {
      string title = "bread order";
      Order newOrder = new Order(title, "12 orders of bread", 5, "1/26/2024");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }


    [TestMethod]
    public void GetDescription_ReturnsDescriptionValue_String()
    {
      string description = "12 orders of bread";
      Order newOrder = new Order("bread", description, 12, "1/26/2024");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceValue_Int()
    {
      int price = 5;
      Order newOrder = new Order("bread", "12 orders of bread", price, "1/26/2024");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_ReturnsDateValue_DateTime()
    {
      string date = "1/26/2024";

      Order newOrder = new Order("bread", "12 orders of bread", 5, date);

      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void SetTitle_SetsTitleValue_Void()
    {
      string title = "bread";
      Order newOrder = new Order(title, "12 orders of bread", 15, "1/26/2024");
      string updatedTitle = "pastry";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void SetDescription_SetsDescriptionValue_Void()
    {
      string description = "12 orders of bread";
      Order newOrder = new Order("bread", description, 15, "1/26/2024");
      string updatedDescription = "12 orders of pastry";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }
  }
}