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

            
            var NewAnimal = new Animal { Name = "Tiger", Weight = 1, Age = 5 };
            List<Animal> Animals = new List<Animal>();
            Animals.Add(NewAnimal);
            foreach (var animal in Animals)
            Console.WriteLine(animal.Stats());
            Console.ReadLine();

            var NewDog = new Dog { Name = "snupy", Weight = 5, Age = 10 };
            List<Dog> dog = new List<Dog>();
            dog.Add(NewDog);
            foreach (var dogg in dog)
            Console.WriteLine(dogg.Stats());
            Console.ReadLine();

        }

    }
        
    }
