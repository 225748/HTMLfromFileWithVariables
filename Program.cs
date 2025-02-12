using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLfromFileWithVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader htmlFile = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "/HTMLBookingConfirmation.html");
            //To check file path - it should find this projects debug folder and then go to the file specified
            //Console.WriteLine((AppDomain.CurrentDomain.BaseDirectory + "/HTMLBookingConfirmation.html").ToString());
            //Console.ReadLine();

            string currentLine;
            StreamReader currentFile = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "/FILENAME");
            while (!currentFile.EndOfStream)
            {
                currentLine = currentFile.ReadLine();
                Console.WriteLine(currentLine);
            }
            currentFile.Close();
            Console.ReadLine();



        }
    }
}
