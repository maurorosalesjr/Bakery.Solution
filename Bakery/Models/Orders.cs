using System.Collections.Generic;

namespace Bakery.Models
{
  public class Orders
  {
    private static List<Orders> _instances = new List<Orders>();
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; set; }

    public Orders(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Orders> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Orders Find(int id)
    {
      return _instances[id - 1];
    }
  }
}