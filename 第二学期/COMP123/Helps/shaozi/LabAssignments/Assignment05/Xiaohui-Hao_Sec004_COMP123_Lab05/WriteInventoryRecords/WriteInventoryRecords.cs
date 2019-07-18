using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteInventoryRecords
{
    class WriteInventoryRecords
    {
        static void Main(string[] args)
        {
            const int END = 999;
            const string DELIM = ",";
            const string FILENAME = @"C:\Lab05_Textfiles\inventory.txt";
            Inventory inv = new Inventory();

            FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            Console.Write("Enter inventory number or " + END + " to quit >> ");
            inv.InvNum = Convert.ToInt32(Console.ReadLine());
            while (inv.InvNum != END)
            {

                Console.Write("Enter inventory number>> ");
                inv.InvNum = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter inventory description>> ");
                inv.InvDec = Console.ReadLine();

                Console.Write("Enter inventory price>> ");
                inv.InvPrice = Convert.ToDouble(Console.ReadLine());

                writer.WriteLine(inv.InvNum + DELIM + inv.InvDec +
                   DELIM + inv.InvPrice);
                Console.Write("Enter next inventory number or " +
                   END + " to quit >> ");
                inv.InvNum = Convert.ToInt32(Console.ReadLine());
            }           
            
            // Error occurs if the next two statements are reversed
            writer.Close();
            outFile.Close();       

        }
       

    }
    class Inventory
    {

        public int InvNum { get; set; }
        public string InvDec { get; set; }
        public double InvPrice { get; set; }
    }

}


