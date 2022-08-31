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

        public FamilyCarsClass(int FuelPerKM, int _Year, int _Distance, int _Safety, int _Price, string _CompanyName, string _Color, string _VehicleName, string _LicensePlate, int _Doors, int _Seats, int _Storage) :
            base(_Doors, _Seats, _Storage , _Year, _Distance, _Safety, _Price, _CompanyName, _Color, _VehicleName , _LicensePlate)
        {
            this.FuelPerKM = FuelPerKM;
        }

    public VehicleClass CreateNewFamilyCar(int FuelPerKM, int _Year, int _Distance, int _Safety, int _Price, string _CompanyName, string _Color, string _VehicleName, string _LicensePlate, int _Doors, int _Seats, int _Storage)
        {
          VehicleClass f = new FamilyCarsClass(FuelPerKM, _Year, _Distance, _Safety, _Price, _CompanyName, _Color, _VehicleName, _LicensePlate, _Doors, _Seats, _Storage);
            return f;
        }
    }
}
