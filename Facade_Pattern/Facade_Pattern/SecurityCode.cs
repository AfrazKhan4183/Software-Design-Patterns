using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class SecurityCode
    {
        private string securityCode = "2015N4183";
        public string getcode()
        {
            return securityCode;
        }

        public bool checkCode(string g)
        {
            if(g==securityCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
