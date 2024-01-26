using System.Collections.Generic;


namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set;}
    public string Description { get;}

    public Order(string title, string description)
    {
      Description = description;
      Title = title;
    }
  }
}