using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Dog  : Animal 
    {
        private string dname;

        public string DName
        {
            get { return dname; }
            set { dname = value; }
        }
        public Dog() { }
        public Dog(int ag, int weig, string nam) : base (ag, weig, nam)
        {
            dname = DName;
        }

    }
}
