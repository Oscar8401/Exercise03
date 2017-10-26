using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
   public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        private string color;
        private string haircolor;
        private int shoosesize;

        public int Age { get { return age; } set { age = value; } }
        public string FName { get { return fName; } set { fName = value; } }
        public string LName { get { return lName; } set { lName = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

        public string Color { get { return color; } set { color = value; } }
        public string Haircolor { get { return haircolor; } set { haircolor = value; } }
        public int Shoosesize { get { return shoosesize; } set { shoosesize = value; } }


    }
    
}
   