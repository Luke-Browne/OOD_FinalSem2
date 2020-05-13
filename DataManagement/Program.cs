using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LukeBrowne_S00187306;

namespace DataManagement
{
  class Program
  {
    static void Main(string[] args)
    {
      Phone db = new Phone();

      using (db)
      {
        Phone p1 = new Phone() { Name = "Samsung S20", Price = 500, OperatingSystem = "Android", OS_Image = "/images/android.png", Phone_Image = "/images/s20.jpg" };
      }
    }
  }
}
