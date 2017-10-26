using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise03
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
        public virtual string PrintAnimal()
        {
            return "name of animal" + Name + "weight of its is :" + Weight + "its age:" +age+ ".";
        }

    }
}
