using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Constructor
{
    public class ConstructorType
    {
        //Static Constructor
        static ConstructorType()
        {
            Console.WriteLine("Static Constructor");
        }
        //Instance constructor
        public ConstructorType()
        {
            Console.WriteLine("Instance Constructor");
        }
    }
}
