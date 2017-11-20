using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class nocard: ATMState
    {
        public ATMMachine atm;
        public nocard(ATMMachine g)
        {
            atm = g;
        }
        public void ejectCard()
        {
            Console.WriteLine("Enter Card 1st...");
        }

        public void insertCard()
        {
            Console.WriteLine("Please Enter Pin");
            atm.changeState(atm.hascard());
        }

        public void insertPin(int pin)
        {
            Console.WriteLine("Enter Card 1st...");
        }

        public void requestCash(int cash)
        {
            Console.WriteLine("Enter Card 1st...");
        }



    }
}
