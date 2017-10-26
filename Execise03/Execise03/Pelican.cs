using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Pelican:Bird
    {
        private string fish;

        public string Fish
        {
            get { return fish; }
            set { fish = value; }
        }

        public Pelican() { }

        public Pelican(string nam, int wei, int ag) : base (nam,wei,ag)
        {
            Fish = fish;
        }

        

        public override string State()
        {
            return "How many fish it can hold: " + fish;
        }
    }
}
