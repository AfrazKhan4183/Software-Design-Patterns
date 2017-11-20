using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public  class Funds_Check
    {
        private int availableCash = 200000;
        public int getavailableCash()
        {
            return availableCash;
        }

        public void decreasecash(int h)
        {
            availableCash -= h;
        }

        public void increasecash(int h)
        {
            availableCash += h;
        }

        public bool haveenoghmoney(int j)
        {
            if(j>availableCash)
            {
                Console.WriteLine("Error: N0 have enogh money");
                Console.WriteLine("Current Cash: " + getavailableCash());
                return false;
            }
            else
            {
                decreasecash(j);

                Console.WriteLine("Cash is provided.....Current Cash is: "+getavailableCash());
                         return true;
            }
        }

        public void CashDeposit(int h)
        {
            increasecash(h);
            Console.WriteLine("Cash is Deposited.....Current Cash is: " + getavailableCash());
        }
    }
}
