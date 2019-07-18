using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class SalespersonDemo
    {
        static void Main(string[] args)
        {
            RealEstateSalesperson purchase1 = new RealEstateSalesperson("Fernando", "Martins", 10000.00, 10);
            Console.WriteLine(purchase1.ToString());
            Console.WriteLine("Total earnings: {0}\n\n", purchase1.MakeSale());
            RealEstateSalesperson purchase2 = new RealEstateSalesperson("Sandra", "Bullock", 100000.00, 5);
            Console.WriteLine(purchase2.ToString());
            Console.WriteLine("Total earnings: {0}\n\n", purchase2.MakeSale());

            GirlScout cookie1 = new GirlScout("Cameron", "Dias", 10);
            cookie1.MakeSale();
            Console.WriteLine(cookie1.ToString());
            GirlScout cookie2 = new GirlScout("Harrison", "Ford", 15);
            cookie2.MakeSale();
            Console.WriteLine(cookie2.ToString());

        }
    }
}
