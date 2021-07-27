using AbstractDP.Abstract;
using AbstractDP.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Factory mercedes = new MercedesFactory();
            Client c = new Client(mercedes);
            Console.WriteLine("-----------Mercedes---------");
            Console.WriteLine(c.GetHeadLight());
            Console.WriteLine(c.GetTire());
            Factory audi = new AudiFactory();
            Client c1 = new Client(audi);
            Console.WriteLine("-----------AudiFactory---------");
            Console.WriteLine(c1.GetHeadLight());
            Console.WriteLine(c1.GetTire());
            Console.ReadKey();

        }
    }
}
