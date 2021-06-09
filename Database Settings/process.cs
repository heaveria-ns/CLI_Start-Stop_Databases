using System;

namespace Database_Settings
{
    public class process
    {
        // Run PowerShell script. Params: (string) Argument to run, (bool) as an admin or not.
        public static void PowershellArgument(string argument, bool admin)
        {
            var powershell = new System.Diagnostics.ProcessStartInfo();
            powershell.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            powershell.UseShellExecute = true;
            if (admin) { powershell.Verb = "RunAs"; }
            powershell.Arguments = argument;
            try
            {
                Console.WriteLine("Please wait...");
                System.Diagnostics.Process.Start(powershell);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Success!");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: You did not give permission to perform the requested action." +
                       $"\nDetailed Error:\n{e}");
                Console.ResetColor();
            }
        }
    }
}