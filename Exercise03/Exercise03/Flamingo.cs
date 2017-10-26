using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
   public class Flamingo : Bird
    {
        private int flyingHeight;

        public int FlyingHeight
        {
            get { return flyingHeight; }
            set { flyingHeight = value; }
        }
        public Flamingo() { }
        public Flamingo (int ag, int weig, string nam) : base (ag, weig, nam)
        {
            FlyingHeigh = flyingHeight;
        }
    }
}
