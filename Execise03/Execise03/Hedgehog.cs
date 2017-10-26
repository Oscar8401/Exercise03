using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Hedgehog:Animal
    {
        private string tones;

        public string Tones
        {
            get { return tones; }
            set { tones = value; }
        }

        public Hedgehog() { }

        public Hedgehog(string nam, int wei, int ag) : base (nam,wei,ag)
        {
            Tones = tones;
        }


        public override string Stats()
        {
            return base.Stats() + "how many tons are there: " + tones;
        }
    }
}
