using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class hascard:ATMState
    {
        public ATMMachine atm;
        public hascard(ATMMachine g)
        {
            atm = g;
        }

        public void ejectCard()
        {
            Console.WriteLine("Card ejected...");
            atm.changeState(atm.nocard());
        }

        public void insertCard()
        {
            Console.WriteLine("U cann't enter more than one card...");
        }

        public void insertPin(int pin)
        {
            if (pin == 1234)
            {
                Console.WriteLine("Correct pin");
                atm.shortmoney = true;
                atm.changeState(atm.correctPinn());
            }
            else
            {
                Console.WriteLine("Wrong pin");
                atm.shortmoney = false;
                Console.WriteLine("Wrong pin");
                atm.changeState(atm.nocard());
            }
        }

        public void requestCash(int cash)
        {
            Console.WriteLine("Enter Pin first...");
        }
    }
}
