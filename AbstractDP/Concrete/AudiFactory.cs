using AbstractDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDP.Concrete
{
    public class AudiFactory : Factory
    {
        public override HeadLight makeHeadLight()
        {
            return new AudiHeadLight();
        }

        public override Tire makeTire()
        {
            return new AudiTire();
        }
    }
}
