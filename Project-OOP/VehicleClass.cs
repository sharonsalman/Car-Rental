using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{

    class VehicleClass
    {
        private int Year;
        private int Distance;
        private int Safety;
        private int Price;
        private string CompanyName;
        private string Color;
        private string VehicleName;

        public VehicleClass(int _Year, int _Distance , int _Safety , int _Price ,
            string _CompanyName , string _Color , string _VehicleName)
        {
            Year = _Year;
            Distance = _Distance;
            Safety = _Safety;
            Price = _Price;
            CompanyName = _CompanyName;
            Color = _Color;
            VehicleName = _VehicleName;
        }

    }
}
