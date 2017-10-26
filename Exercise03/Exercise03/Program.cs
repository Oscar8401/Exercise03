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
            ////to instantiate a new person
            //Person per = new  Person();

            //per.FName = "Priya";
            //per.LName = "Tada";
            //per.Age = 22;
            //per.Height= 167;
            //per.Weight= 65;
 
        }
        
    }
}
