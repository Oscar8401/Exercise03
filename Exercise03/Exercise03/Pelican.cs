using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Pelican : Bird
    {
        private string pelicanColor;

        public string PelicanColor 
        {
            get { return pelicanColor; }
            set { pelicanColor = value; }
        }
        public Pelican() { }
        public Pelican (int ag, int weig, string nam) : base(ag, weig, nam)
        {
            PelicanColor = pelicanColor;
        }
    }
}
