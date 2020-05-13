using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeBrowne_S00187306
{
  public class Phone
  {
    #region Properties

    public string Name { get; set; }
    public decimal Price { get; set; }
    public string OperatingSystem { get; set; }
    public string OS_Image { get; set; }
    public string Phone_Image { get; set; }

    #endregion Properties

    #region Constructors
    public Phone(string name, decimal price, string operatingSystem, string os_Image, string phone_Image)
    {
      Name = name;
      Price = price;
      OperatingSystem = operatingSystem;
      OS_Image = os_Image;
      Phone_Image = phone_Image;
    }
    #endregion Constructors

    public void IncreasePrice(decimal percentage)
    {
      Price = Price * percentage;
    }
  }
}
