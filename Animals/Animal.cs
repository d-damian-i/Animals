using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals {
    class Animal {

        public string Name;
        public int Aggression;
        public int Lifespan;
        public bool EatsMeat;
        public string Noise;
        

        public void Move() {
            
        }

        public void MakeNoise() {
            Console.WriteLine(Name + " just said " + Noise);
        }

        public Animal(string name, string noise) {
            Name = name;
            Noise = noise;

        }



    }
}
