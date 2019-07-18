using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classified
{
    class Program
    {

    

    static string QUIT = "Would you like to chooss: [y]es or [e]xit?";
    static string INPUT = "What ad you want put?";
    static void Main(string[] args)
    {


        Classfied adinfo1 = new Classfied("starbucks", "drinks good", 20);
        Classfied adinfo2 = new Classfied("CinePlex", "Best entertainment place", 0);
        Classfied adinfo3 = new Classfied("Wechat", "Lets chat!", 35);
        Classfied adinfo4 = new Classfied("LOL", "Lets play games!", 15);



        Console.Write("would you like input ad/view ads/or quit?");
        string inputad = Console.ReadLine();


        Console.WriteLine(adinfo1.GetInfo());
        Console.WriteLine(adinfo2.GetInfo());
        Console.WriteLine(adinfo3.GetInfo());
        Console.WriteLine(adinfo4.GetInfo());


            Console.WriteLine("press any key to exit");
            String y = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine();
        }
        }

    }

