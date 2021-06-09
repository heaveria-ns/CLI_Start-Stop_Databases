using System;
using static Database_Settings.process;
using static Database_Settings.cli;

namespace Database_Settings
{
    class Program
    {
        static void Main(string[] args)
        {
            string argument = Interface();
            PowershellArgument(argument, true);
            
            // Prevent Auto-Shutdown
            Console.ReadKey();
        }
    }
}