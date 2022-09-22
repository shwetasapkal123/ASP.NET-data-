using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class InsertionSort
    {
        public static void SortArray()
        {
            int[] array = new int[] {23,9,11 };
            int i, j, val, flag;

            for (i=0;i<array.Length;i++)
            {
                val = array[i];
                flag = 0;
                for(j=i-1;j>=0 && flag!=1;)
                {
                    if(val<array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j+1]=val;
                    }
                    else 
                        flag = 1;
                }
            }

            foreach(int e in array)
            {
                Console.WriteLine(e);
            }
        }
        
    }
}
