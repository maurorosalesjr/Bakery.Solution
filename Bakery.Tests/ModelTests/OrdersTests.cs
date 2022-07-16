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
      Orders newOrder = new Orders("Title", "Description", 1, "Date")
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }
  }
}