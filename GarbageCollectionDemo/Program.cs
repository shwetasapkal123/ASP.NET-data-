using System;

namespace GarbageCollectionDemo
{
    public class IntWrapped
    {
        public int wrapprdInt;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //Console.WriteLine("Total generation is: "+GC.MaxGeneration);
            //Console.WriteLine();

            //Console.WriteLine("Total memory1: "+GC.GetTotalMemory(false));
            //IntWrapped wrapped1=new IntWrapped();
            //var wrapped2 = new IntWrapped();
            //var wrapped3 = new IntWrapped();
            //Console.WriteLine(GC.GetGeneration(wrapped1));
            //Console.WriteLine("Total memory2: "+GC.GetTotalMemory(false));
            //wrapped1.wrapprdInt = 1;
            //wrapped2.wrapprdInt = 2;
            //wrapped3.wrapprdInt = 3;
            //Console.WriteLine("Total memory3: "+GC.GetTotalMemory(false));
            //wrapped2=null;
            //GC.Collect();
            //Console.WriteLine("Total memory4: "+GC.GetTotalMemory(false));
            //Console.WriteLine(GC.GetGeneration(wrapped1));
            long mem1 = GC.GetTotalMemory(false);
            
                int[] values=new int[5000];
                values=null;
            
            long mem2=GC.GetTotalMemory(false);
            
                GC.Collect();
            
            long mem3=GC.GetTotalMemory(false);
            
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            
        }
    }
}
