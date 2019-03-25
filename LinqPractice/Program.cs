using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq Problem 1
            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics"};
            var thWords = words.Where(w => w.Contains("th"));

            foreach(var result in thWords)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();

            //Linq Problem 2
            var names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var noDuplicateNames = names.Distinct();

            foreach (var result in noDuplicateNames)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();

            //Linq Problem 3
            var grades = new List<string>(){
                    "80,100,92,89,65",
                    "93,81,78,84,69",
                    "73,88,83,99,64",
                    "98,100,66,74,55"
            };
            var intGrades = grades.Select(g => (Array.ConvertAll(g.Split(','), int.Parse)));
            var AvgNoMinGrades = intGrades.Select(g => g.Where(x => g.Min() != x).Average()).Average();
            Console.WriteLine(AvgNoMinGrades);
            Console.ReadLine();

        }
    }
}
