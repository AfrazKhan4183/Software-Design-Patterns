using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class UFOEnemy:EnemyShip
    {
        public UFOEnemy()
        {
            setname("UFO enemy ship");
            setdamage(20.0);
        }
    }
}
