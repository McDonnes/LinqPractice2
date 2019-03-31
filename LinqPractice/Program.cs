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
            Console.WriteLine("Problem 1: ");
            ProblemOne(new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" });
            Console.WriteLine("\n\nProblem 2: ");
            ProblemTwo(new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" });
            Console.WriteLine("\n\nProblem 3: ");
            ProblemThree(new List<string>(){
                    "80,100,92,89,65",
                    "93,81,78,84,69",
                    "73,88,83,99,64",
                    "98,100,66,74,55"
            });
            Console.WriteLine("\n\nProblem 4: ");
            ProblemFour("Terril");
            Console.ReadLine();
        }
        static void ProblemOne(List<string> words)
        {
            var thWords = words.Where(w => w.Contains("th"));
            foreach (var result in thWords)
            {
                Console.WriteLine(result);
            }
        }
        static void ProblemTwo(List<string> names)
        {
            var noDuplicateNames = names.Distinct();

            foreach (var result in noDuplicateNames)
            {
                Console.WriteLine(result);
            }
        }
        static void ProblemThree(List<string> grades)
        {
            var intGrades = grades.Select(g => (Array.ConvertAll(g.Split(','), int.Parse)));
            var AvgNoMinGrades = intGrades.Select(g => g.Where(x => g.Min() != x).Average()).Average();
            Console.WriteLine(AvgNoMinGrades);
        }
        static void ProblemFour(string word)
        {
            var condense = (word.ToUpper().ToCharArray()).GroupBy(p => p).ToDictionary(g => g.Key, g => g.Count()).OrderBy(g => g.Key);
            foreach (KeyValuePair<char, int> x in condense)
            {
                var temp = x.Key;
                Console.Write(temp);
                int temp2 = x.Value;
                Console.Write(temp2);
            }
        }
    }
}
