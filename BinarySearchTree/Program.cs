using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(50);
            tree.Add(70);
            tree.Add(60);
            tree.Add(20);
            tree.Add(90);
            tree.Add(10);
            tree.Add(40);
            tree.Add(100);

            tree.TravesePreOrder(tree.Root);
            Console.WriteLine();
            Console.WriteLine();
            tree.TraveseInOrder(tree.Root);
            Console.WriteLine();
            Console.WriteLine();
            tree.TravesePostOrder(tree.Root);


            Dictionary<int, string> result = new Dictionary<int, string>();
            result.Add(1, "C#");
            result.Add(2, "C#");
            result.Add(3, "python");
            result.Add(5, "C++");

            foreach(KeyValuePair<int, string> pair in result)
            {
                Console.WriteLine("  "+pair.Key+"  "+pair.Value);
                //Console.Write("  "+pair.Value);
            }
            Hashtable hashtable = new Hashtable();
            hashtable.Add("one", 1);
            hashtable.Add(2, "hghjgkj");
            hashtable.Add(3.45, 56);
            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Key+"  "+entry.Value);
            }


            Console.ReadLine();
        }
    }
}
