using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    //1.creating a class animal
    public class Animal
    {
       //adding properities to the class
        private string name;
        private int weight;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Weight { get { return weight; } set { weight = value; } }
        public int Age { get { return age; } set { age = value; } }
        
        //3. creating a constructor
        public Animal () { }

        public Animal (int ag, int weig, string nam)
        {
            name = nam;
            weight = weig;
            age = ag;
        }

    }
}
