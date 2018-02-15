using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2
{
    interface IDrivable
    {
        //Interfaces ONLY have public methods, therefore the private/public operators aren't used at all

        int Size { get; set; }

        void WriteWheels();
    }
}
