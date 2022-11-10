using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

            Parallel.Invoke(
                () =>
                {
                    Console.WriteLine("Begin first task");
                    GetLongestWord(words);
                },
                () =>
                {
                    Console.WriteLine("Begin second task");
                    GetMostCommonWord(words);
                },
                () =>
                {
                    Console.WriteLine("begin third task");
                    GetCountforWords(words,"sleep");
                });
            Console.WriteLine("returned from Parallel.Invoke");
        }
        public static string[] CreateWordArray(string url)
        {
            Console.WriteLine("Retrieving from "+url);
            string blog=new WebClient().DownloadString(url);
            return blog.Split(new char[] {' ','\u000A',',','.',
            ':',';','_','-','/'},
            StringSplitOptions.RemoveEmptyEntries);
            
        }

        public static string GetLongestWord(string[] words)
        {
            var longestWord = (from w in words
                               orderby w.Length descending
                               select w).First();
            Console.WriteLine("Task1  longest word is "+longestWord);
            return longestWord;
        }
        public static void GetMostCommonWord(string[] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;
            var commonWord = frequencyOrder.Take(10);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 2   the most common words are: ");

            foreach(var v in commonWord)
            {
                sb.AppendLine(v);
            }
            Console.WriteLine(sb.ToString());
        }

        public static void GetCountforWords(string[] words,string term)
        {
            var findWord = from word in words
                           where word.ToUpper().Contains(term.ToUpper())
                           select word;

            Console.WriteLine("Task 3  the word {0} occurrs {1} times",term,findWord.Count());

        }
    }
}
