using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileProvider.Models
{
  public class User
  {
    private IProvider provider;

    public int UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }

    public User(IProvider providerParam)
    {
      provider = providerParam;
    }

    public string GetMessage()
    {
      return provider.MessageFromProvider();
    }
  }
}