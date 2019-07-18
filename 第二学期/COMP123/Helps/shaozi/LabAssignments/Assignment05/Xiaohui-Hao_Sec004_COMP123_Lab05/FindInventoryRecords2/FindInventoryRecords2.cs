using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindInventoryRecords2
{
    class FindInventoryRecords2
    {
        static void Main(string[] args)
        {
            const int END = 999;
            const string FILENAME = @"C:\Lab05_TextFiles\inventory.txt";

            Inventory inv = new Inventory();
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            string recordIn;
            string[] fields;
            double miniPri;
            Console.Write("Enter inventory number to find or " +
               END + " to quit >> ");
            miniPri= Convert.ToDouble(Console.ReadLine());

            while (miniPri != END)
            {
                Console.WriteLine("\n{0,-5}{1,-12}{2,8}\n",
                    "Num", "Describe", "Price");
                inFile.Seek(0, SeekOrigin.Begin);
                recordIn = reader.ReadLine();
                while (recordIn != null)
                {
                    fields = recordIn.Split(',');
                    inv.InvNum = Convert.ToInt32(fields[0]);
                    inv.InvDec = fields[1];
                    inv.InvPrice = Convert.ToDouble(fields[2]);
                    if (inv.InvPrice >= miniPri)
                        Console.WriteLine("{0,-5}{1,-12}{2,8}",
                           inv.InvNum, inv.InvDec,
                              inv.InvPrice.ToString("C"));
                    recordIn = reader.ReadLine();
                }
                Console.Write("Enter minimum Price to find or " +
              END + " to quit >> ");
                miniPri = Convert.ToDouble(Console.ReadLine());
            }
            reader.Close();  // Error occurs if
            inFile.Close(); //these two statements are reversed
        }
    }
}
class Inventory
{

    public int InvNum { get; set; }
    public string InvDec { get; set; }
    public double InvPrice { get; set; }
}

        
  