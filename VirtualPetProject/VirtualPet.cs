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
        private int vpSleepy = 10;
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
        public int VpSleepy
        {
            get { return this.vpSleepy; }
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
                vpHungry++;
                vpWaste--;
                Console.WriteLine("Waste - {0}", vpHungry);
            }
            else
            {
                vpWaste--;
                Console.WriteLine("{0} isn't hungry right now", vpName);
                Console.WriteLine("Waste - {0}", vpWaste);
            }
            
        }
        public void letOut()
        {
            Console.WriteLine("Let Out");
        }
        public void play()
        {
            Console.WriteLine("Play");
        }
        public void toVet()
        {
            Console.WriteLine("Vet");
        }
        public void ignore()
        {
            Console.WriteLine("Ignore");
        }
        public void tick()
        {
            Console.WriteLine("Tick");
        }
    }
}
