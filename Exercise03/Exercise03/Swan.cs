using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Swan : Bird 
    {
        private string ginder;

        public string Ginder
        {
            get { return ginder; }
            set { ginder = value; }
        }
        public Swan() { }
        public Swan(int ag, int weig, string nam) : base(ag, weig, nam)
        {
            ginder = Ginder;
        } 
                    
    }
}
