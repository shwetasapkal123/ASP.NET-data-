using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo1
{
    public class Sum
    {
        Nlog obj=new Nlog();
        public void Add(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                obj.LogError("a and b values are zero");
                obj.LogWarn("a and b values should not be equal to zero");
            }
            else
            {
                int result = a + b;
                Console.WriteLine("Addition is "+result);

                obj.LogDebug("The debugging");
                obj.LogInfo("Addition method is passed " + result);
            }    

        }
    }
}
