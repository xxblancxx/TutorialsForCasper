using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2
{
    class Car : IDrivable
    {
        public int Size
        {
            get
            {
                return 5;
            }
            set
            {
                // Do nothing
            }
        }

        public void WriteWheels()
        {
            Console.WriteLine("This Object has 4 Wheels");
        }

        public void ActivateFourWheelDrive()
        {
            Console.WriteLine("Four Wheel Drive Activated!");
        }
    }
}
