using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public interface ATMState
    {

        void insertCard();
        void ejectCard();
        void insertPin(int pin);
        void requestCash(int cash);
        
    }
}
