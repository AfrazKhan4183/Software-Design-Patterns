using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class correctpin:ATMState
    {
        public ATMMachine atm;
        public correctpin(ATMMachine g)
        {
            atm = g;
        }

        public void ejectCard()
        {
            Console.WriteLine("card ejected...");
            atm.changeState(atm.nocard());
        }

        public void insertCard()
        {
            Console.WriteLine("U cann't enter more than one cards...");
        }

        public void insertPin(int pin)
        {
            Console.WriteLine("already have a pin...");
        }

        public void requestCash(int cash)
        {
            if (cash > atm.money)
            {
                Console.WriteLine("not enogh cash");
                Console.WriteLine("Card ejected...");
                atm.changeState(atm.nocard());
            }
            else
            {
                Console.WriteLine(cash + "is provided");
                atm.setmoney(atm.money - cash);
                Console.WriteLine("Card ejected...");
                atm.changeState(atm.nocard());
            }
            if (cash <= 0)
            {
                atm.changeState(atm.outofMOney());
            }
        }





    }
}
