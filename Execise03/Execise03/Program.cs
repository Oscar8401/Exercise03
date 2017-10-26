using Exercise03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {


            PersonHandler per = new PersonHandler();

            per.CreatPerson(33, "Lokesh", "bandaru", 180, 75);


            var NewAnimal = new Animal { Name = "Lion", Age = 18, Weight= 120 };

            List<Animal> Animals = new List<Animal>();
            Animals.Add(NewAnimal);

            foreach (var animal in Animals) Console.WriteLine(animal.State());
            Console.ReadLine();

            //creating a list that take objects of type dog.

            var NewDog = new Dog {Name = "Cocker Spaniel", Age = 9, Weight = 12, Play = "playing with its ball" };
            List<Dog> Newdog = new List<Dog>();
            //we can not add an object of type horse because it have anothe properities
            //our list must have the type of animal.
            Newdog.Add(NewDog);
            //9.printing out all animals stats using foreach
            //11. printing out that stats for only objects of type dog.
            foreach (var animal in Newdog) Console.WriteLine(animal.State());
            Console.ReadLine();



  
        }

    }
}