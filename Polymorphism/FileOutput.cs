using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class FileOutput : Output
    {
        private string _filePath;

        public FileOutput(string filePath)
        {
            _filePath = filePath;
        }

        public override void EchoSomethingToALine(string value)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(value);
            }
        }
    }
}
