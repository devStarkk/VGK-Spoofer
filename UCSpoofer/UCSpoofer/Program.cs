using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UCSpoofer.Functions;

namespace UCSpoofer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MessageBox.Show("if your paid for this you are scammed");
                options.ConsoleOPT();
            }
            catch(Exception error)
            {
                // Show MessageBox with error if an exception run
                MessageBox.Show(error.ToString()); 
            }
        }
    }
}
