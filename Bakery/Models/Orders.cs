using System.Collections.Generic;

namespace Bakery.Models
{
  public class Orders
  {
    public string Title { get; set; }


    public Orders(string title, string description, int price, string date)
    {
      Title = title;
    }
  }
}