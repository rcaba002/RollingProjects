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
        }

        private static string[] GetNames()
        {
            return new [] {
                "John Doe",
                "Jane Doe",
                "Superman"
            };
        }
    }
}
