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
            clsEmailManager emailManager = new clsEmailManager();
            string templateFilePath = (AppDomain.CurrentDomain.BaseDirectory + "/simple.html");

            //Make an array of variables to replace
            clshtmlVariable[] variableReplacement = new clshtmlVariable[2];//num of unique variables in html template
            clshtmlVariable htmlVariable;

            //for every unique var in the template do this
            htmlVariable = new clshtmlVariable("{x}","12");
            variableReplacement[0] = htmlVariable;

            htmlVariable = new clshtmlVariable("{y}", "43");
            variableReplacement[1] = htmlVariable;

            string htmlBody = emailManager.ReadAndPopulateEmailTemplate(templateFilePath,variableReplacement);
            emailManager.SendEmail("benjaminjfranklin99@gmail.com", htmlBody, "Test Email");
            Console.ReadLine();



        }
    }
}
