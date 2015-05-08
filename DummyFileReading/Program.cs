using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyFileReading
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInteraction file = new FileInteraction();
            file.Path = "c:/work";

            string fileData = file.ReadFromFile();
            string[] dataPieces = BreakDataApartOnCommas(fileData);
            string[] sortedDataPieces = Alphabetize(dataPieces);
            string commaSeparatedList = PutBackTogether(sortedDataPieces);
            file.WriteDataToFile(commaSeparatedList);

            Console.WriteLine(fileData);
            Console.ReadLine();
        }

        private static string PutBackTogether(string[] sortedDataPieces)
        {
            return "some,new,string";
        }

        private static string[] Alphabetize(string[] dataPieces)
        {
            string[] pieces = new string[2];
            pieces[0] = "foo";
            pieces[1] = "bar";
            return pieces;
        }

        /// <summary>
        /// Done, and good to go!
        /// </summary>
        private static string[] BreakDataApartOnCommas(string fileData)
        {
            return fileData.Split(',');
        }
    }
}
