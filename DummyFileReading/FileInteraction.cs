using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyFileReading
{
    class FileInteraction
    {
        internal string ReadFromFile()
        {
            return "\"Some data\",\"from\",\"file\"";
        }

        internal void WriteDataToFile(string commaSeparatedList)
        {
        }

        public string Path { get; set; }
    }
}
