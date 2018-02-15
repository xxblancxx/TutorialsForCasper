using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Step 3 part
            var drivableList = new List<IDrivable>();
            drivableList.Add(new Motorcycle());
            drivableList.Add(new Motorcycle());
            drivableList.Add(new Motorcycle());
            drivableList.Add(new Car());
            drivableList.Add(new Car());

            foreach (var vehicle in drivableList)
            {
                vehicle.WriteWheels(); //Common method

                //vehicle.ActivateFourWheelDrive(); <---- Cannot do this, because it's defined in Car, and not in common interface.
            }
            #endregion

            //Seperate outputs
            Console.WriteLine();
            Console.WriteLine();

            #region Step 5 part
            var mixedList = new List<IDrivable>();

            mixedList.Add(new Mercedes());
            mixedList.Add(new Mercedes());
            mixedList.Add(new Lada());
            mixedList.Add(new Motorcycle());
            mixedList.Add(new Car());

            foreach (var vehicle in mixedList)
            {
                vehicle.WriteWheels(); //Common method

                //vehicle.ActivateFourWheelDrive(); <---- Cannot do this, because it's defined in Car, and not in common interface.

                //vehicle.PrintLada();              <---- Cannot do this, because it's defined in Lada, and not in common parent.
                //vehicle.PrintMercedes();          <---- Cannot do this, because it's defined in Mercedes, and not in common parent.
            }

            //Seperate outputs
            Console.WriteLine();
            Console.WriteLine();

            var carList = new List<Car>();
            carList.Add(new Lada());
            carList.Add(new Lada());
            carList.Add(new Mercedes());
            carList.Add(new Mercedes());

            foreach (var vehicle in carList)
            {
                vehicle.WriteWheels(); //Common method

                vehicle.ActivateFourWheelDrive(); //Common method

                //vehicle.PrintLada();              <---- Cannot do this, because it's defined in Lada, and not in common parent.
                //vehicle.PrintMercedes();          <---- Cannot do this, because it's defined in Mercedes, and not in common parent.
            }
            #endregion
        }
    }
}
