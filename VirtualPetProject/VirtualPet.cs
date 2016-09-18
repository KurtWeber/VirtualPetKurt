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
            }
            else
            {
                Console.WriteLine("{0} isn't hungry right now", vpName);
            }
            Console.WriteLine("Hunger - {0}", vpHungry);
            Console.WriteLine("Waste - {0}", vpWaste);
            Console.WriteLine("Boredom - {0}", vpBoredom);
            Console.WriteLine("Sick - {0}\n", vpSick);

        }
        public void letOut()
        {
            if (vpWaste < 10)
            {
                vpHungry--;
                vpWaste = 10;
            }
            else
            {
                Console.WriteLine("{0} doesn't need to go out right now", vpName);
            }
            Console.WriteLine("Hunger - {0}", vpHungry);
            Console.WriteLine("Waste - {0}", vpWaste);
            Console.WriteLine("Boredom - {0}", vpBoredom);
            Console.WriteLine("Sick - {0}\n", vpSick);
        }
        public void play()
        {
            if (vpBoredom < 10)
            {
                vpBoredom += 2;
                vpHungry -= 2; ;
            }
            else
            {
                Console.WriteLine("{0} doesn't want to play right now", vpName);
            }
            Console.WriteLine("Hunger - {0}", vpHungry);
            Console.WriteLine("Waste - {0}", vpWaste);
            Console.WriteLine("Boredom - {0}", vpBoredom);
            Console.WriteLine("Sick - {0}\n", vpSick);
        }
        public void toVet()
        {
            if (vpSick < 10)
            {
                vpSick = 10;
                vpHungry--;
                vpBoredom--;

                Console.WriteLine("Vet");
            }
            Console.WriteLine("Hunger - {0}", vpHungry);
            Console.WriteLine("Waste - {0}", vpWaste);
            Console.WriteLine("Boredom - {0}", vpBoredom);
            Console.WriteLine("Sick - {0}\n", vpSick);
        }
        public void ignore()
        {
            Console.WriteLine("Hunger - {0}", vpHungry);
            Console.WriteLine("Waste - {0}", vpWaste);
            Console.WriteLine("Boredom - {0}", vpBoredom);
            Console.WriteLine("Sick - {0}\n", vpSick);
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
