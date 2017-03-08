using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {   //StringBuilder allows for strings to be mutable


            //Declare a new StringBuilder
            StringBuilder builder = new StringBuilder();
            builder.Append("The list starts here: ");
            builder.AppendLine();
            builder.Append("1 cat").AppendLine();

            //get a reference to the StringBuilder's buffer content
            string innerString = builder.ToString();

            //display with console

            Console.WriteLine(innerString);
        }
    }
}
