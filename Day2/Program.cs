using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{

    //class definition
    
    class Program
    {
        static void Main(string[] args)
        {
            //dogstuff();
            Warrior barton = new Warrior("barton");
            Warrior griff = new Warrior("griff");

            griff.Attack(barton);
            barton.Attack(griff);
            griff.Attack(barton);
            griff.Attack(barton);
            griff.Attack(barton);



            Console.WriteLine(barton);
            Console.WriteLine(griff);
        }

        private static void dogstuff()
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
            //Console.WriteLine(maysie.name);

            var Scout = new Dog("Scout");
            Scout.HappyBirthday();
            var Damon = new Dog("Damon");
            var Gus = new Dog("Gus");

            //Console.WriteLine(maysie);
            maysie.AddFriend(Scout);
            maysie.AddFriend(Damon);
            maysie.AddFriend(Gus);
            maysie.AddFriend(Damon);

            maysie.GetDogFriends();
            maysie.RemoveFriend(Gus);
            maysie.GetDogFriends();
        }
    }
}
