using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Dog : Animal
    {
        private string play;

        public string Play
        {
            get { return play; }
            set { play = value; }
        }

        public Dog() { }

        public Dog(string nam, int wei, int ag) : base (nam,wei,ag)
        {
            play = Play;
        }

        public override  string State()
        {
            return "What our dog is doing now? " + play;
        }
        public override string Speak()
        {
            return "Woff!";
        }
    }
}
