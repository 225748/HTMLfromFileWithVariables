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
            Console.WriteLine("This terminal will automatically close upon sending the email");
            //

            clsEmailManager emailManager = new clsEmailManager();
            string templateFilePath = (AppDomain.CurrentDomain.BaseDirectory + "/Html_Email_Templates/newUserEmailTemplate.html");//directs to its own debug folder and then the file

            //Make an array of variables to replace in the html template
            clshtmlVariable[] variableReplacements = new clshtmlVariable[4];//num of unique variables in html template
            clshtmlVariable htmlVariable;

            //for every unique variable in the template do this
            //htmlVariable = new clshtmlVariable("{x}","12");
            //variableReplacements[0] = htmlVariable;

            //htmlVariable = new clshtmlVariable("{y}", "43");
            //variableReplacements[1] = htmlVariable;

            variableReplacements[0] = new clshtmlVariable("{firstName}", "Benjamin");
            variableReplacements[1] = new clshtmlVariable("{lastName}", "Franklin");
            variableReplacements[2] = new clshtmlVariable("{email}", "benjaminjfranklin99@gmail.com");
            variableReplacements[3] = new clshtmlVariable("{temporaryPassword}", "12DOGTQ");

            string htmlBody = emailManager.ReadAndPopulateEmailTemplate(templateFilePath,variableReplacements);

            emailManager.SendEmail("benjaminjfranklin99@gmail.com", htmlBody, "Your New Rota Connect Account!");
            //improvement from old style is that the credentials file location no longer needs to be passed into this function with every call
            //the file location is now stored in the email manager class itself




        }
    }
}
