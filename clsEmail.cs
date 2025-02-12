using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLfromFileWithVariables
{
    internal class clsEmail
    {
        public string ReadAndPopulateEmailTemplate(string filePath, clshtmlVariable[] variableReplacement)
        {
            //Read the file in
            StreamReader htmlFile = new StreamReader(filePath);
            string htmlString = "";
            while (!htmlFile.EndOfStream)
            {
                htmlString = htmlString + htmlFile.ReadLine();
            }
            htmlFile.Close();

            //replace variable placeholders in the htmlString to contain their actual value
            foreach (clshtmlVariable htmlVariable in variableReplacement)
            {
                htmlString.Replace(htmlVariable.fileIdentifier, htmlVariable.variableValue);
            }

            return htmlString;
        }
    }
}
