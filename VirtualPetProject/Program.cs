using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Congratulations on purchasing your new Virtual Pet!");
            Console.Write("Please enter a name for your new Virtual Pet: ");
            string vpName = Console.ReadLine();
            Console.WriteLine("\nTaking good care of your Virtual Pet {0} will give you many years", vpName);
            Console.WriteLine("of enjoyment.\n");
            Console.WriteLine("But beware, not taking care of your Virtual Pet may result in some");
            Console.WriteLine("unwanted behavior.\n");
            Console.WriteLine("Meet {0}!\n", vpName);
            Console.WriteLine("            __,__");
            Console.WriteLine("   .--.  .-\"     \"-.  .--.");
            Console.WriteLine("  / .. \\/  .-. .-.  \\/ .. \\");
            Console.WriteLine(" | |  '|  /   Y   \\  |'  | |");
            Console.WriteLine(" | \\   \\  \\ 0 | 0 /  /   / |");
            Console.WriteLine("  \\ '- ,\\.-\"`` ``\"-./, -' /");
            Console.WriteLine("   `'-' /_   ^ ^   _\\ '-'`");
            Console.WriteLine("       |  \\._   _./  |");
            Console.WriteLine("       \\   \\ `~` /   /");
            Console.WriteLine("        '._ '-=-' _.'");
            Console.WriteLine("           '~---~'\n");




        }
    }
}
