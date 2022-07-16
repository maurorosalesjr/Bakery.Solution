using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrdersTests
  {


    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Orders()
    {
      Orders newOrder = new Orders("Title", "Description", 1, "Date");
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      //Arrange
      string title = "croissants"
      Orders newOrder = new Orders(title, "Description", 1, "Date");

      //Act
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result)
    }
  }
}