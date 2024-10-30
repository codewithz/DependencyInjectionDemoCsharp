using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Without_DI
{
    public  class ToyCar
    {
        ////private RegularBattery _battery;
        //private RechargableBattery _battery;

        //public ToyCar()
        //{
        //    //_battery = new RegularBattery();
        //    _battery = new RechargableBattery();
        //}

        private readonly IBattery _battery;
        //Constructor Injection of the battery into the ToyCar
        public ToyCar(IBattery battery)
        {
            _battery = battery;
        }

        public void Run()
        {
            Console.WriteLine("Toy Car is starting");
            _battery.SupplyPower();
            Console.WriteLine("Toy Car is running");

        }
    }
}
