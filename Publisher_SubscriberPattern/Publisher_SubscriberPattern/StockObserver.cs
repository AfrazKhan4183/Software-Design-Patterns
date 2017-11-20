using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher_SubscriberPattern
{
    public class StockObserver:Observer
    {
        private int ip;
        private int gp;
        private int appp;


        private static int trackerid = 0;
        private Subject stockobsever;
        private int observerID;
        private Stock stock;
        public StockObserver(Stock g)
        {
            this.stock = g;
            observerID = ++trackerid;

            Console.WriteLine("New Observer: " + this.observerID);
            stock.register(this);
        }
        

        
public void update(int appleprice, int googleprice, int abmprice)
        {
            ip = abmprice;
            appp = appleprice;
            gp = googleprice;
            printprices();            
        }

        public void printprices()
        {
            Console.WriteLine("Observer " + this.observerID+"\n"+"IBM Price: "+this.ip+"\n"
                +"APPLE Price: "+this.appp+"\n"+"GOOGLE Price: "+this.gp);
        }
    }
}
