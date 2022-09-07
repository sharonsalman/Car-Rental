using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{

   public abstract class VehicleClass
    {
        public int Year { get; private set; }

        public int Distance { get; private set; }
        public int Safety { get; private set; }
        public int Price { get; private set; }
        public string CompanyName { get; private set; }
        public string Color { get; private set; }
        public string VehicleName { get; private set; }
        public int LicensePlate { get; private set; }

        public VehicleClass(int _Year, int _Distance , int _Safety , int _Price ,
            string _CompanyName , string _Color , string _VehicleName , int _LicensePlate)
        {
            Year = _Year;
            Distance = _Distance;
            Safety = _Safety;
            Price = _Price;
            CompanyName = _CompanyName;
            Color = _Color;
            VehicleName = _VehicleName;
            LicensePlate = _LicensePlate;
        }

        public override string ToString()
        {
            return this.VehicleName;
        }

    }
}
