using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
   public class Animal
    {
        private string name;
        private int weight;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

             public int Weight
        {
            get { return weight; }
            set { weight = value; }

        }

        public int Age
        {
            get { return age; }
            set {age = value; }

        }

        public Animal() { }

        public Animal(string nam,int wei,int ag)
        {
            name = nam;
            weight = wei;
            age = ag;
        }




        //creating the method.
        //virtual is important, means this method can be overloaded. 
        public virtual string State()
        {
            return "Our animal is: " + name + "\nWeight: " + weight + "\nAge:" +age+ ".";
        }

        public virtual string Speak()
        {
            return "What it said? ";
        }

    }
}
