using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Factoryclass
    {
        public EnemyShip makeEnemy(string option)
        {
            //EnemyShip enemy=null;
            if(option.Equals("U"))
            {
                return new UFOEnemy();
            }
            else if(option.Equals("R"))
            {
                return new Rocketenemyship();
            }
            else if(option.Equals("M"))
            {
                return new MachineGunenemy();
            }
            else
            {
                return null;
            }
        }
    }
}
