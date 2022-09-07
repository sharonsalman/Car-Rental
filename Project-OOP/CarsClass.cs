using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    class CarsClass : Project_OOP.VehicleClass
    {
        public int Doors { get; private set; }
        public int Seats { get; private set; }
        public int Storage { get; private set; }

        public CarsClass(int _Doors, int _Seats, int _Storage, int _Year, int _Distance, int _Safety, int _Price, string _CompanyName, string _Color, string _VehicleName, int _LicensePlate) : base(_Year, _Distance, _Safety, _Price, _CompanyName, _Color, _VehicleName, _LicensePlate)
        {
            Doors = _Doors;
            Seats = _Seats;
            Storage = _Storage;
        }
    }
}
