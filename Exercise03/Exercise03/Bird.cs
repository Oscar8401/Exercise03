using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
   public class Bird : Animal
    {
        private int flyingHeigh;

        public int FlyingHeigh 
        {
            get { return flyingHeigh; }
            set { flyingHeigh = value; }
        }
        public Bird() { }
        public Bird (int ag, int weig, string nam) : base ( ag, weig, nam)
        {
            flyingHeigh = FlyingHeigh;
        }
    }
}
