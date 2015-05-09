using Faker;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Process.Start("notepad.exe", "./sortedNames.txt");
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

        private static void WriteNamesToFile(string fileName, string[] sortedNames)
        {
            File.WriteAllLines(fileName, sortedNames);
        }

        private static string[] GetNames()
        {
            string[] names = new string[20000];
            for (var i = 0; i < names.Length; i++)
            {
                names[i] = Name.FullName();
            }

            return names;
        }
    }
}
