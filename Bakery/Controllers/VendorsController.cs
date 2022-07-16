using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string name, string description)
    {
      Vendor vendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(id);
      List<Orders> orders = vendor.Orders;
      model.Add("vendor", vendor);
      model.Add("orders", orders);
      return View(model);
    }

    [HttpPost("/vendor/{vendorId}/orders")]
    public ActionResult Create(int vendorID, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor allVendors = Vendor.Find(vendorID);
      Orders newOrder = new Orders(orderTitle, orderDescription, orderPrice, orderDate);
      allVendors.AddOrder(newOrder);
      List<Orders> vendorOrders = allVendors.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", allVendors);
      return RedirectToAction("Index");
    }
  }
}