using AbstractDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDP.Concrete
{
    public class MercedesFactory : Factory
    {
        public override HeadLight makeHeadLight()
        {
            return new MercedesHeadLight();
        }

        public override Tire makeTire()
        {
            return new MercedesTire();
        }
    }
}
