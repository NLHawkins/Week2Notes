using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{

    //class definition
    class Dog
    {
        //setting to public makes class accessible, but changeable!
        //setting to private makes the definition not accesible to any other class outside this method
        private int Age;
        public string name;

        

        //Constructor
        public Dog(string _name)
        {
            Age = 0;
            name = _name;
        }

        public void HappyBirthday()
        {
            Age++;
        }

        //exposing private variable through public accessor
        public int GetAge()
        {
            return Age;
        }

        public int GetAgeDogYears()
        {
            return Age * 7;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var maysie = new Dog("Maysie");
            maysie.HappyBirthday();
            maysie.HappyBirthday();
            maysie.HappyBirthday();
            maysie.HappyBirthday();
            var age = maysie.GetAge();
            var ageDogYears = maysie.GetAgeDogYears();
            Console.WriteLine(age);
            Console.WriteLine(ageDogYears);
        }
    }
}
