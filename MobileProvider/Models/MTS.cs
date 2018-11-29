namespace MobileProvider.Models
{
  public class MTS : IProvider
  {
    public string MessageFromProvider()
    {
      return "Ваш провайдер MTS!";
    }
  }
}