using System;
using System.Collections.Generic;
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
    }
}
