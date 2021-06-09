using System;

namespace Database_Settings
{
    public class cli
    {
        public static string Interface()
        {
            string[] options = {"Start MariaDB", "Stop MariaDB"};
            int i = 1;
            foreach (var item in options)
            {
                Console.WriteLine($"{i}: {item}");
                i++;
            }
            Console.Write("\nChoice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return "Start-Service -Name \"MariaDB\"";
                case 2:
                    return "Stop-Service -Name \"MariaDB\"";
            }
            throw new InvalidOperationException();
        }
    }
}