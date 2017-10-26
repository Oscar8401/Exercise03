using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
   public class Horse : Animal
    {
        private int horseSpeed;

        public int HorseSpeed
        {
            get { return horseSpeed; }
            set { horseSpeed = value; }
        }
        public  Horse() { }
        public Horse (int ag, int weig, string nam) : base (ag, weig, nam)
        {
            horseSpeed = HorseSpeed;
        }
    }
}
