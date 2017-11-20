using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class CheckAccount
    {
        private string AccountNo = "AfrazKhan";
        public string getAccount()
        {
            return AccountNo;
        }

        public bool checkAccount(string h)
        {
            if(h==getAccount())
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
