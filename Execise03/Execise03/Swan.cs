using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Swan:Bird
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Swan() { }

        public Swan(string nam, int wei, int ag) : base (nam,wei,ag)
        {
            Color = color;
        }

        public override string State()
        {
            return "which color is it: " + color;
        }
    }
}
