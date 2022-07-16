using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Orders> Orders { get; set; }


    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Orders> { };
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void AddOrder(Orders order)
    {
      Orders.Add(order);
    }

    public static Vendor Find(int id)
    {
      return _instances[id - 1];
    }
  }
}