using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Bird:Animal
    {

        private string wings;

        public string Wings
        {
            get { return wings; }
            set { wings = value; }
        }
        public Bird() { }

        public Bird(string nam, int wei, int ag) : base (nam,wei,ag)
        {
            Wings = wings;
        }


        public override string Stats()
        {
            return base.Stats() + "how height it fly: " + wings;
        }

       
    }
}
