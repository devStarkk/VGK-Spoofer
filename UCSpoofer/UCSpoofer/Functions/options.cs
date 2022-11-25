using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UCSpoofer.Functions
{
    internal class options
    {
        public static void ConsoleOPT()
        {
        beginOpt:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("if you paid for this you scammed");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[1]: ");
            Console.WriteLine("Spoof");
            Console.Write("[2]: ");
            Console.WriteLine("Clean");
            Console.Write("[3]: ");
            Console.WriteLine("Hwid Checker");

            string select = Console.ReadLine();

            if (select != "1" && select != "2" && select != "3")
            {
                goto beginOpt;
            } // Invalid Options
            else if (select == "1")
            {
                changer.hwid(); // Start the spoofer
                goto beginOpt;
            } // Spoofer
            else if (select == "2")
            {
                changer.clean(); // Start the cleaner
                goto beginOpt;
            } // Cleaner
            else if (select == "3")
            {
                Process.Start("C:\\UC Spoofer\\files\\hwdcheck.bat"); goto beginOpt; // Start hwid checker and back to the beginning
            } // Hwid Checker
        }
    }
}
