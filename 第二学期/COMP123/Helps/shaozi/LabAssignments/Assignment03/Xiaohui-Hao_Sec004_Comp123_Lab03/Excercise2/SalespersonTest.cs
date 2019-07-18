using System;

namespace Excercise2
{
    class SalespersonTest
    {
        static void Main(string[] args)
        {
            Salesperson salesperson1;
            RealEstateSalesperson realestateperon1 = new RealEstateSalesperson("Xiaohui", "Hao", 100000, 3);
            salesperson1 = realestateperon1;
            Console.WriteLine(salesperson1);
            Console.WriteLine(salesperson1.SalesSpeech());
            Console.WriteLine("Commission of Real Estate Salesperson: " + salesperson1.MakeSale());

            GirlScout girscout1 = new GirlScout("Frick", "Anton", 100); 
            salesperson1 = girscout1;
            Console.WriteLine(salesperson1);
            Console.WriteLine(salesperson1.SalesSpeech());
            Console.WriteLine("The number of boxes of the cookies sold: " + salesperson1.MakeSale());
        }
        
    }
    
}
