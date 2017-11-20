using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher_SubscriberPattern
{
    public class Stock:Subject
    {
     
        private ArrayList observers;
        private int ibm;
        private int goog;
        private int app;

        public  Stock()
        {
            observers = new ArrayList();
        }
        
        public void register(Observer o)
        {
            observers.Add(o);
        }

        public void unregister(Observer o)
        {
            int index = observers.IndexOf(o);
            Console.WriteLine("Observer " + (index +1)+ " deleted");
            observers.Remove(index);
        }

        public void notifyObser()
        {
           foreach(Observer g in observers)
            {
                g.update(app, goog, ibm);
            }
        }

        public void setibm(int h)
        {
            ibm = h;
            notifyObser();
        }

        public void setgoog(int h)
        {
            goog = h;
            notifyObser();
        }

        public void setapp(int h)
        {
            app = h;
            notifyObser();
        }
    }
}
