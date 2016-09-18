using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject
{
    class VirtualPet
    {
        // Fields - Variables
        private string vpName;
        private int vpHungry = 10;
        private int vpWaste = 10;
        private int vpBoredom = 10;
        private int vpSick = 10;

        // Properties
        public string VpName
        {
            get { return this.vpName; }
            set { this.vpName = value; }
        }
        public int VpHungry
        {
            get { return this.vpHungry; }
        }
        public int VpWaste
        {
            get { return this.vpWaste; }
        }
        public int VpBoredom
        {
            get { return this.vpBoredom; }
        }
       public int VpSick
        {
            get { return this.vpSick; }
        }
        
        // Constructors

        // Methods
        public void feed()
        {
            if (vpHungry < 10)
            {
                vpHungry = 10;
                vpWaste--;
                Console.WriteLine("You've fed {0}                       ", vpName);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} isn't hungry right now", vpName);
                Console.WriteLine();
                vpBoredom -= 2; 
            }
            Console.SetCursorPosition(0, Console.CursorTop - 17);
            Console.WriteLine("Hunger - {0} ", vpHungry);
            Console.WriteLine("Waste - {0} ", vpWaste);
            Console.WriteLine("Boredom - {0} ", vpBoredom);
            Console.WriteLine("Sick - {0} ", vpSick);
            Console.WriteLine();

        }
        public void letOut()
        {
            if (vpWaste < 10)
            {
                vpHungry--;
                vpWaste = 10;
                Console.WriteLine("You've let {0} out                   ", vpName);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} doesn't need to go out right now", vpName);
                Console.WriteLine();
                vpBoredom -= 2;
            }
            Console.SetCursorPosition(0, Console.CursorTop - 17);
            Console.WriteLine("Hunger - {0} ", vpHungry);
            Console.WriteLine("Waste - {0} ", vpWaste);
            Console.WriteLine("Boredom - {0} ", vpBoredom);
            Console.WriteLine("Sick - {0} ", vpSick);
            Console.WriteLine();
        }
        public void play()
        {
            if (vpBoredom < 10)
            {
                vpBoredom = 10;
                vpHungry -= 2;
                Console.WriteLine("You've played with {0}               ", vpName);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} doesn't want to play right now   ", vpName);
                Console.WriteLine();
                vpBoredom -= 2;
            }
            Console.SetCursorPosition(0, Console.CursorTop - 17);
            Console.WriteLine("Hunger - {0} ", vpHungry);
            Console.WriteLine("Waste - {0} ", vpWaste);
            Console.WriteLine("Boredom - {0} ", vpBoredom);
            Console.WriteLine("Sick - {0} ", vpSick);
            Console.WriteLine();
        }
        public void toVet()
        {
            if (vpSick < 10)
            {
                vpSick = 10;
                vpHungry--;
                vpBoredom--;
                Console.WriteLine("You've taken {0} to the vet          ", vpName);
                Console.WriteLine();
            }
            else
            {
                vpBoredom += 2;
                Console.WriteLine("{0} feels fine                       ", vpName);
                Console.WriteLine();
            }
            Console.SetCursorPosition(0, Console.CursorTop - 17);
            Console.WriteLine("Hunger - {0} ", vpHungry);
            Console.WriteLine("Waste - {0} ", vpWaste);
            Console.WriteLine("Boredom - {0} ", vpBoredom);
            Console.WriteLine("Sick - {0} ", vpSick);
            Console.WriteLine();
        }
        public void ignore()
        {
            if (vpHungry < 10)
            {
                vpHungry -= 2;
            }
            if (vpWaste < 10)
            {
                vpWaste -= 2;
            }
            if (vpBoredom < 10)
            {
                vpBoredom -= 3;
            }
            if (vpSick < 10)
            {
                vpSick -= 2;
            }
            Console.WriteLine("Ingnoring {0} will only upset your pet   ", vpName);
            Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop - 17);
            Console.WriteLine("Hunger - {0} ", vpHungry);
            Console.WriteLine("Waste - {0} ", vpWaste);
            Console.WriteLine("Boredom - {0} ", vpBoredom);
            Console.WriteLine("Sick - {0} ", vpSick);
            Console.WriteLine();

        }
        public void tick()
        {
            Console.WriteLine("Hunger - {0}", vpHungry);
            Console.WriteLine("Waste - {0}", vpWaste);
            Console.WriteLine("Boredom - {0}", vpBoredom);
            Console.WriteLine("Sick - {0}\n", vpSick);
        }
    }
}
