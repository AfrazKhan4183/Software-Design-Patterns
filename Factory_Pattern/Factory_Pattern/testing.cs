using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factory_Pattern
{
    public class testing
    {
        Factoryclass g = new Factoryclass();
        EnemyShip en = null;
        public string option;
        public EnemyShip EnemyGen()
        {
            if(option.Equals("U"))
            {
                en = g.makeEnemy(option);
                return en;
            }
            else if(option.Equals("R"))
            {
                en = g.makeEnemy(option);
                return en;
            }
            else if(option.Equals("M"))
            {
                en = g.makeEnemy(option);
                return en;
            }
            else
            {
                Console.WriteLine("enter a valid enemy");
                return null;
            }
           
            
        }
       
        public void doenemystuff(EnemyShip h)
        {
            h.followheroship();
            h.displayenemyship();
            h.enemyshoots();
        }
    }
}
