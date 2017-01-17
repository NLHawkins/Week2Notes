using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    enum State
    {
        Alive, Dead, Graveyard
    }
    class Warrior
    {
        //CLASS MEMBERS below. Are available to all methods within class Warrior
        private int hp;
        public string name;
        public State currentState = State.Alive;

        public Warrior(string _name)
        {
            name = _name;
            hp = 10;
        }

        public void LowerHP()
        {
            if (hp <= 3)
            {
                Console.WriteLine($"{name} is dead and cannot be attacked");
                hp = 0;
                currentState = State.Dead;
            }
            else
            {
                hp -= 3;
            }
        }

        public void Attack(Warrior enemy)
        {
            enemy.LowerHP();
            Console.WriteLine($"{name} attacked {enemy.name}!");
        }

        public override string ToString()
        {
            return $"{name} : {hp}";
        }
    }
}
