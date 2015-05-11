using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUtilities
{
    public class StringList
    {
        private string[] passedInArray;

        public StringList()
        {

        }

        public StringList(string[] passedInArray)
        {
            this.passedInArray = passedInArray;
            Length = passedInArray.Length;
        }

        public int Length { get; set; }

        public string Get(int p)
        {
            return passedInArray[p];
        }
    }
}
