using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Hedgehog : Animal
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Hedgehog() { }
        public Hedgehog(int ag, int weig, string nam) : base(ag, weig, nam)
        {
            color = Color;
        }
    }
}
