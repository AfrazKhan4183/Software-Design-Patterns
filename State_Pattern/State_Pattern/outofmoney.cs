using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    class outofmoney : ATMState
    {
        public ATMMachine atm;
        public outofmoney(ATMMachine g)
        {
            atm = g;
        }


        public void ejectCard()
        {
            Console.WriteLine("we donn't have money,, insert the card");
        }

        public void insertCard()
        {
            Console.WriteLine("we donnn't have mone");

        }

        public void insertPin(int pin)
        {
            Console.WriteLine("we donnn't have mone");
        }

        public void requestCash(int cash)
        {
            Console.WriteLine("we donnn't have mone");
        }
    }
}
