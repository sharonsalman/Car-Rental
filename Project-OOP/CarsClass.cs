using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    class CarsClass : Project_OOP.VehicleClass
    {
        int Doors;
        int Seats;
        int Storage;

        public CarsClass(int Doors, int Seats, int Storage , int _Year, int _Distance, int _Safety, int _Price, string _CompanyName, string _Color, string _VehicleName) : base(_Year, _Distance, _Safety, _Price, _CompanyName, _Color, _VehicleName)
        {
            this.Doors = Doors;
            this.Seats = Seats;
            this.Storage = Storage;
        }

    }
}
