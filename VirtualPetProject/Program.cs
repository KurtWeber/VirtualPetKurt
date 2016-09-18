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
            // Initialize menuOption
            int menuOption;
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

            // Virtual pet status
            Console.WriteLine("{0}'s status\n", newVPet.VpName);

            Console.WriteLine("Hunger - {0}", newVPet.VpHungry );
            Console.WriteLine("Waste - {0}", newVPet.VpWaste);
            Console.WriteLine("Boredom - {0}", newVPet.VpBoredom);
            Console.WriteLine("Sick - {0}\n", newVPet.VpSick);

            // Menu selection
            do
            {
                Console.WriteLine("What do you want to do for {0}? \n", newVPet.VpName);
                Console.WriteLine("1. Feed {0}", newVPet.VpName);
                Console.WriteLine("2. Let {0} out", newVPet.VpName);
                Console.WriteLine("3. Play with {0}", newVPet.VpName);
                Console.WriteLine("4. Take {0} to the vet", newVPet.VpName);
                Console.WriteLine("5. Ignore {0}", newVPet.VpName);
                Console.WriteLine("6. Quit the game\n");

                // Menu to Class methods
                menuOption = int.Parse(Console.ReadLine());
                switch (menuOption)
                {
                    case 1:
                        newVPet.feed();
                        break;
                    case 2:
                        newVPet.letOut();
                        break;
                    case 3:
                        newVPet.play();
                        break;
                    case 4:
                        newVPet.toVet();
                        break;
                    case 5:
                        newVPet.ignore();
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Please select options 1 - 6");
                        break;
                }
            } while (menuOption != 6); 
        }
    }
}
