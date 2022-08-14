using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    class FamilyCarsClass : Project_OOP.CarsClass
    {
        int FuelPerKM;

        public FamilyCarsClass(int FuelPerKM, int _Year, int _Distance, int _Safety, int _Price, string _CompanyName, string _Color, string _VehicleName) : base(_Year, _Distance, _Safety, _Price, _CompanyName, _Color, _VehicleName)
        {
            this.FuelPerKM = FuelPerKM;
        }
    }
}
