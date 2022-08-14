using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    class BikesClass : Project_OOP.VehicleClass
    {
     int MaxSpeed;

        public BikesClass(int MaxSpeed, int _Year, int _Distance, int _Safety, int _Price, string _CompanyName, string _Color, string _VehicleName) : base(_Year, _Distance, _Safety, _Price, _CompanyName, _Color, _VehicleName)
        {
            this.MaxSpeed = MaxSpeed;
        }
    }



}
