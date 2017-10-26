using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise03
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


        public override string PrintAnimal()
        {
            return "how height it fly: " + wings;
        }
    }
}
