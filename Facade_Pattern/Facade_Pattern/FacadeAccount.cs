using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class FacadeAccount
    {
        private string account;
        private string code;

        SecurityCode c;
        CheckAccount ch;
        Funds_Check f;
        Welcome n;
        
        public FacadeAccount(string c2,string c3)

        {
            
            account = c2;
            code = c3;
             n = new Welcome();
            ch = new CheckAccount();
            c = new SecurityCode();
            f = new Funds_Check();

        }
        
        public string getccount()
        {
            return account;
        }
        public string getcod()
        {
            return code;
        }

        public void withdrawCash(int zx)
        {
            if((ch.checkAccount(getccount())==true)&&(c.checkCode(getcod())==true)&&(f.haveenoghmoney(zx)==true))
            {
                Console.WriteLine("Transection Complete..."); 
            }
            else
            {
                Console.WriteLine("Transection Failed...");
            }
        }

        public void DepositCaash(int g)
        {
           if((ch.checkAccount(getccount())==true)&&(c.checkCode(getcod())==true))
            {
                Console.WriteLine("Deposit Complete...");
                f.CashDeposit(g);
            }
            else
            {
                Console.WriteLine("Transection Failed...");
            }
        }
    }
}
