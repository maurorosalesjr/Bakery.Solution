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
      string title = "croissants";
      Orders newOrder = new Orders(title, "Description", 1, "Date");

      //Act
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnOrderDescription_String()
    {
      //Arrange
      string description = "buttery flakey";
      Orders newOrder = new Orders("Title", description, 1, "Date");

      //Act
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnOrderPrice_Int()
    {
      //Arrange
      int price = 1;
      Orders newOrder = new Orders("Title", "Description", price, "Date");

      //Act
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnOrderDate_String()
    {
      //Arrange
      string date = "7/15/2022";
      Orders newOrder = new Orders("Title", "Description", 1, date);

      //Act
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrdersList()
    {
      //Arrange
      string title1 = "croissants";
      string title2 = "danish";
      Orders newOrder1 = new Orders(title1, "description", 1, "date");
      Orders newOrder2 = new Orders(title2, "description", 2, "date");
      List<Orders> newList = new List<Orders> { newOrder1, newOrder2 };

      //Act
      List<Orders> result = Orders.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}