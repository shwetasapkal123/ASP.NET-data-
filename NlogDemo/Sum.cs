using System;
using System.Collections.Generic;
using System.Text;

namespace NlogDemo
{
    public class Sum
    {
        private readonly Nlog obj=new Nlog();

        public void Add(int a, int b)
        {
            if(a==0 || b==0)
            {
                obj.LogError("a and b value is 0");
            }
            else
            {
                obj.LogDebug("The debugging");
            }
        }
    }
}
