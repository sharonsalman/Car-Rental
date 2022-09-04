using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_OOP.FamilyCarsClass;
using static Project_OOP.SportsCarsClass;
using static Project_OOP.CarsClass;
using static Project_OOP.VehicleClass;
using static Project_OOP.BikesClass;


namespace Project_OOP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vehicle());
            

        }
    }
}
