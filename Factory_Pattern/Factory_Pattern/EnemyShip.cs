using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public abstract class EnemyShip
    {
        private string name;
        private double damage;
        public string getname()
        {
            return name;
        }
        public double getdamage()
        {
            return damage;
        }

        public void setname(string n)
        {
            name = n;
        }
        public void setdamage(double n)
        {
            damage = n;
        }

        public void followheroship()
        {
            Console.WriteLine(getname() + "is following the hero");
        }

        public void displayenemyship()
        {
            Console.WriteLine(getname() + "is on the screen");
        }

        public void enemyshoots()
        {
            Console.WriteLine(getname()+"attacks on hhero n does damage " + getdamage());
        }
    }
}
