using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDP.Abstract
{
    public abstract  class Factory
    {
        public abstract HeadLight makeHeadLight();
        public abstract Tire makeTire();
    }
}
