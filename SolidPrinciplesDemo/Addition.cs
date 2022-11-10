using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesDemo
{
    public  class Addition:Abstract
    {
        public void Add(int a,int b)
        {
            Demo demo = new Demo();
        }
        //public void Subtract(int a , int b)
        //{

        //}
        
    }
    public class Demo : Abstract
    {
        public void Add(int a, int b, int c)
        {

        }
    }
}
