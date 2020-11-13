using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals {
    class Beetle : Animal {
        public Beetle(string name, string noise) : base(name, noise) {


        }

        public void roll() {
            Console.WriteLine(Name + " do be rollin");
        }
    }
}
