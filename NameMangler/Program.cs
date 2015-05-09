using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameMangler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = GetNames();
            string[] sortedNames = SortNames(names);
            WriteNamesToFile("./sortedNames.txt", sortedNames);

            Console.ReadLine();
        }

        private static string[] SortNames(string[] names)
        {
            string[] sortedNames = new string[names.Length];
            names.CopyTo(sortedNames, 0);

            Array.Sort(sortedNames);

            return sortedNames;
        }

        private static string GetLowestName(string first, string second)
        {
            return string.Compare(first, second) < 0 ? first : second;
        }

        private static void WriteNamesToFile(string p, string[] sortedNames)
        {
            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }
        }

        private static string[] GetNames()
        {
            return new[] {
                "John Doe",
                "Jane Doe",
                "Superman"
            };
        }
    }
}
