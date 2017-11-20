using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class ATMProxy :GetATMdata
    {
        public ATMState getATMState()
        {
            ATMMachine h = new ATMMachine();
            Console.WriteLine("State is: " + h.getATMState());
            return h.getATMState();
        }

        public int getCashinMachine()
        {
            ATMMachine g = new ATMMachine();
            Console.WriteLine("State is: " + g.getCashinMachine());
            return g.getCashinMachine();
        }
    }
}
