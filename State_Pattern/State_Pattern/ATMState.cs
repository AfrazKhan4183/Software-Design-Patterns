using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    interface ATMState
    {
        void insertCard();
        void ejectCard();
        void insertPin(int pin);
        void requestCash(int cash);
    }
}
