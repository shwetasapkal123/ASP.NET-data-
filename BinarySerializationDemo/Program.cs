using System;

namespace BinarySerializationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Binary binary = new Binary();
            //binary.Serialize();
            binary.Deserialize();
        }
    }
}
