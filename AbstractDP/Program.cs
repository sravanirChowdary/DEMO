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
            Client c2 = new Client(audi);
            Console.WriteLine("-----------AudiFactory---------");
            Console.WriteLine(c2.GetHeadLight());
            Console.WriteLine(c2.GetTire());
            Console.ReadKey();

        }
    }
}
