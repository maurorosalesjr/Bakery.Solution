using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
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
      Vendor newVendor = new Vendor("Vendor name", "Vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      //Arange
      string name = "Vendor Test";
      Vendor newVendor = new Vendor(name, "Vendor Description");

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      //Arrange
      string name = "Vendor Test";
      Vendor newVendor = new Vendor(name, "Vendor Description");

      //Act
      string updatedName = "Test Vendor";
      newVendor.Name = updatedName;
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnVendorDescription_String()
    {
      //Arrange
      string description = "Vendor Description";
      Vendor newVendor = new Vendor("Vendor Name", description);

      //Act
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Vendor Description";
      Vendor newVendor = new Vendor("Vendor Name", description);

      //Act
      string updatedDescription = "Coffee Shop";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      //Arrange
      string name1 = "Coffee Shop";
      string name2 = "Tea House";
      Vendor newVendor1 = new Vendor(name1, "Vendor Description");
      Vendor newVendor2 = new Vendor(name2, "Vendor Description");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      //Arrange
      string name = "Vendor Name";
      Vendor newVendor = new Vendor(name, "Vendor Description");

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void AddOrder_ReturnsVendorOrder_OrderList()
    {
      //Arrange
      Orders newOrder = new Orders("Croissants", "buttery", 1, "7/15/2022");
      Vendor newVendor = new Vendor("Suzie's Cafe", "Small cafe in busy part of town");
      newVendor.AddOrder(newOrder);
      List<Orders> newList = new List<Orders> { newOrder };

      //Act
      List<Orders> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name1 = "Vendor Test one";
      string name2 = "Test Vendor two";
      Vendor newVendor1 = new Vendor(name1, "test description");
      Vendor newVendor2 = new Vendor(name2, "Test description");

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result)
    }
  }
}