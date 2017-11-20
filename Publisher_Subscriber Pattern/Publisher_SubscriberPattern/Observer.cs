using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher_SubscriberPattern
{
    public interface Observer
    {
        void update(int appleprice,int googleprice,int abmprice);
    }
}
