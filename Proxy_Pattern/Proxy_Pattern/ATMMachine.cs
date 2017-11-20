using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
        public class ATMMachine :GetATMdata 
        {
            public ATMState Hascard;
            public ATMState Nocard;
            public ATMState Correctpin;
            public ATMState Outofmoney;
            public ATMState atmstate;
            public bool shortmoney = false;
            public int money = 200000;


            public ATMMachine()
            {
                Hascard = new hascard(this);
                Nocard = new nocard(this);
                Correctpin = new correctpin(this);
                Outofmoney = new outofmoney(this);

                atmstate = Nocard;
                if (money < 0)
                {
                    atmstate = Outofmoney;
                }
            }

            public void changeState(ATMState g)
            {
                atmstate = g;
            }
            public void setmoney(int h)
            {
                money = h;
            }

            public void insertcard()
            {
                atmstate.insertCard();
            }
            public void ejectcard()
            {
                atmstate.insertCard();
            }
            public void insertpin(int h)
            {
                atmstate.insertPin(h);
            }
            public void requestCash(int h)
            {
                atmstate.requestCash(h);
            }


            public ATMState hascard()
            {
                return Hascard;
            }
            public ATMState nocard()
            {
                return Nocard;
            }
            public ATMState correctPinn()
            {
                return Correctpin;
            }
            public ATMState outofMOney()
            {
                return Outofmoney;
            }

        public int getCashinMachine()
        {
            return money;
        }

        public ATMState getATMState()
        {
            return atmstate;
        }
    }
    }
