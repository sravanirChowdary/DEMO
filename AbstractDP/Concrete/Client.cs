using AbstractDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDP.Concrete
{
    public class Client
    { 
        HeadLight headlight;
        Tire tire;

    
        public Client(Factory factory)
        {
            headlight = factory.makeHeadLight();
            tire = factory.makeTire();
        }
        public string GetHeadLight()
        {
            return headlight.HName();
        }
        public string GetTire()
        {
            return tire.TName();
        }
    }
}
