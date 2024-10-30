using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Without_DI
{
    public class RechargableBattery : IBattery
    {
        public  void SupplyPower()
        { 
            Console.WriteLine("Power supplied by Rechargable Battery");
        }
    }
}
