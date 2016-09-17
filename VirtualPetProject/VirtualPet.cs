﻿using System;
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
        private int vpHungry;
        private int vpWaste;
        private int vpBoredom;
        private int vpSleepy;
        private int vpSick;

        // Properties
        // -Hungry
        // -Waste
        // -Boredom

        // Constructors

        // Methods
        public void feed()
        {
            Console.WriteLine("Feed");
        }
        public void letOut()
        {
            Console.WriteLine("letOut");
        }
        public void play()
        {
            Console.WriteLine("Play");
        }
        public void toVet()
        {
            Console.WriteLine("Vet");
        }
        public void tick()
        {
            Console.WriteLine("Tick");
        }
    }
}
