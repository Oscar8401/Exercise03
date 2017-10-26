using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class PersonHandler
    {
        //creating a new method
 
        public void SetAge (Person pers, int age)
        {
            pers.Age = age;
        }

       
        
        //method that instatiate a person objects
        public Person CreatPerson (int age, string fname, string lname, double height, double weight)
        {
            //important you muste iniutialaize always
            Person per = new Person();
            per.Age = age;
            per.FName = fname;
            per.LName = lname;
            per.Height = height;
            per.Weight = weight;
            
            return new Person();
        }
    }
}
