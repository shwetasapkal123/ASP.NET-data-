using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Interface
{
     interface IAnimalInterface     //Bydefault access modifier is abstract or public
    {
        //int id;           //Erroe bcz we cannot declare fields/variable not instance variable no static variable
        //static int id;
        void  AnimalSound();         //Method 
    }
    class Dog : IAnimalInterface
    {
        public void AnimalSound()
        {
            //throw new NotImplementedException();
            Console.WriteLine("The dog barks");
        }
    }
    class Lion : IAnimalInterface
    {
        public void AnimalSound()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Lion Roars");
        }  
    }
    class Tiger : IAnimalInterface
    {
        public void AnimalSound()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Tiger makes sound girrrrrrrrrrr");
        }
    }
   public abstract class IAnimal
    {
       public abstract void AnimalSound2();
    }
    public class Dog2 : IAnimal
    {
        public override void AnimalSound2()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Bark");
        }
    }
}
