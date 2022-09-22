using System;
using System.Reflection;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //variable metadata
            //int a = 20;
            //Type t = a.GetType();
            //Console.WriteLine(t);
            //Console.WriteLine(t.Assembly);
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.IsValueType);
            //Console.WriteLine(t.IsEnum);

            //Constructor metadata

            Type type = typeof(Addition);
            ConstructorInfo[] constructorInfos = type.GetConstructors(BindingFlags.Public|BindingFlags.Instance);

            foreach(ConstructorInfo constructor in constructorInfos)
            {
                Console.WriteLine(constructor);
            }
            Console.WriteLine();
            Console.WriteLine();
            MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Public|BindingFlags.Instance);

            foreach(MethodInfo method in methodInfos)
            {
                Console.WriteLine(method);
            }

            Console.WriteLine();
            Console.WriteLine();

            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach(PropertyInfo property in propertyInfos)
            {
                Console.WriteLine(property);
            }

        }
    }
}
