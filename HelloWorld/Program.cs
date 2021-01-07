/* HelloWorld program
 * by Ze Zhou 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //using the static member of a class

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0) //I have 1 or more string supplied to my program
            {
                foreach (string word in args)
                {
                    WriteLine($"Hello {word}"); //String Interpolation - $"{expression}"
                }
            }
            else
            {
                //use Verbatim String Literal - @"" - We don't use escape characters, instead we use literal new-line and tab characters
                //display some "help" information
                ForegroundColor = ConsoleColor.Green; //change the color of the text in the console
                WriteLine(@"
Hello World
===== =====

Usage: .\HelloWorld[names]

where
    [names] is a space-seperated list of names"); //public static void WriteLine(string msg){ ... }
            }
            //reset the console text color
            ResetColor(); //.Foreground and .ResetColor are static memebers of the Console class
        }
    }
}
