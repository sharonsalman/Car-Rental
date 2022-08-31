using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    class SportsCarsClass : Project_OOP.CarsClass
    {
        int MaxSpeed;

        public SportsCarsClass(int MaxSpeed, int _Year, int _Distance, int _Safety, int _Price, string _CompanyName,
            string _Color, string _VehicleName ,int _Doors, int _Seats,int  _Storage, string _LicensePlate) : base(_Doors, _Seats, _Storage, _Year, _Distance, _Safety, _Price, _CompanyName, _Color, _VehicleName , _LicensePlate)
        {
            this.MaxSpeed = MaxSpeed;
        }

        public VehicleClass CreateNewSportsCar(int MaxSpeed, int _Year, int _Distance, int _Safety, int _Price, string _CompanyName, string _Color, string _VehicleName, string _LicensePlate, int _Doors, int _Seats, int _Storage)
        {
            VehicleClass s = new FamilyCarsClass(MaxSpeed, _Year, _Distance, _Safety, _Price, _CompanyName, _Color, _VehicleName, _LicensePlate, _Doors, _Seats, _Storage);
            return s;
        }
    }
}

