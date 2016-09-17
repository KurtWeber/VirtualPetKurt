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
            VirtualPet newVPet = new VirtualPet();
            newVPet.VpName = Console.ReadLine();
            Console.WriteLine("\nTaking good care of your Virtual Pet {0} will give you many years of enjoyment.\n", newVPet.VpName);
            Console.WriteLine("But beware, not taking care of your Virtual Pet may result in some unwanted behavior.\n");
            Console.WriteLine("Meet {0}!\n", newVPet.VpName);
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
            Console.WriteLine("           '~---~'\n\n");

            // Create instance of Virtual Pet
            
            newVPet.feed();
            newVPet.letOut();
            newVPet.play();
            newVPet.toVet();
            newVPet.tick();
        }
    }
}
