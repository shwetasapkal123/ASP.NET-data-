using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class Print<T>
    {
        private T[] inputArray;

        public Print(T[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public void PrintArray()
        {
            foreach (var i in inputArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
