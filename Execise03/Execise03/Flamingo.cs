using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise03
{
    class Flamingo:Bird
    {
        private string legs;

        public string Legs
        {
            get { return legs; }
            set { legs = value; }
        }

        public Flamingo() { }

        public Flamingo(string nam, int wei, int ag) : base (nam,wei,ag)
        {
            Legs = legs;
        }


        public override string PrintAnimal()
        {
            return "How long is it's leg's: " + legs;
        }
    }
}
