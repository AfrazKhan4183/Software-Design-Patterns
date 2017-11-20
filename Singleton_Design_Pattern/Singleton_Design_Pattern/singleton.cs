using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Singleton_Design_Pattern
{
    class singleton
       
    { private static singleton instance = null;
        string name;
        public string getname()
        {
            return name;
        }
        private singleton()
        {

        }
        public static singleton make_instance()
        {
            if(instance==null)
            {
                instance = new singleton();
                Console.WriteLine("newly made");
                instance.name = "khan";
            }

          
            return instance;
        
        }


    }
}