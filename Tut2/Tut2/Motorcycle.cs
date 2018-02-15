using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2
{
    class Motorcycle : IDrivable
    {
        public int Size
        {
            get
            {
                return 2;
            }
            set
            {
                // Do nothing
            }
        }

        public void WriteWheels()
        {
            Console.WriteLine("This Object has 2 Wheels");
        }
    }
}
