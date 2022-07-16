using System.Collections.Generic;

namespace Bakery.Models
{
  public class Orders
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }

    public Orders(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
  }
}