using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output consoleVar = new ConsoleOutput();
            //Output fileVar = new FileOutput("c:/work/claim/foo.txt");

            Output outputVar;
            string response = Console.ReadLine();
            if (response == "h")
            {
                outputVar = new ConsoleOutput();
            }
            else if (response == "q")
            {
                outputVar = new Output();
            }
            else
            {
                outputVar = new FileOutput("c:/work/claim.foo.txt");
            }

            WriteSomeStuffToOutput(outputVar);
            //WriteSomeStuffToOutput(fileVar);

            Foo(outputVar as ConsoleOutput);
            //Foo(fileOutput);

            Console.ReadLine();
        }

        static void WriteSomeStuffToOutput(Output output)
        {
            output.EchoSomethingToALine("Howdy");
            output.EchoSomethingToALine("Goodbye");
        }

        static void Foo(ConsoleOutput output)
        {
            if (output == null)
            {
                return;
            }

            output.EchoSomethingToALine("Needs console output");
            output.ChangeColor();
        }
    }

    class Output
    {
        public virtual void EchoSomethingToALine(string value)
        {
            Console.WriteLine("You probably did't want this");

        }
    }
}
