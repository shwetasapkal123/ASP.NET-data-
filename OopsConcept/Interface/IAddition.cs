using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Interface
{
    public interface IAddition
    {
        //int a;
        //Declare abstract method
        //not take attribute or fields
        void AddTwoNumber();
    }
    public interface ISubtract
    {
        //int a;
        //Declare abstract method
        //not take attribute or fields
        void AddTwoNumber();
    }
    //Multiple inheritance using interface
    public class Demo:IAddition,ISubtract
    {
         public void AddTwoNumber()
        {
            int res = 2 + 4;
            Console.WriteLine(res);
        }
        //void ISubtract.AddTwoNumber()
        //{
        //    int res = 4 - 2;
        //    Console.WriteLine(res);
        //}
    }
}
