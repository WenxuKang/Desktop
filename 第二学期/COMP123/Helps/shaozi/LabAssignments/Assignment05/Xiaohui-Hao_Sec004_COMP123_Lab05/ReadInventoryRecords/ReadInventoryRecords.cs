using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ReadInventoryRecords
{
    class ReadInventoryRecords
    {
        static void Main(string[] args)
        {
            //const string DELIM = ",";
            const string FILENAME = @"C:\Lab05_TextFiles\inventory.txt";
            Inventory inv = new Inventory();

            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            string recordIn;
            string[] fields;
            Console.WriteLine("\n{0,-5}{1,-12}{2,8}\n",
               "Num", "Describe", "Price");
            recordIn = reader.ReadLine();

            while (recordIn != null)

            {
                fields = recordIn.Split(',');
                inv.InvNum = Convert.ToInt32(fields[0]);
                inv.InvDec = fields[1];
                inv.InvPrice = Convert.ToDouble(fields[2]);
                Console.WriteLine("{0,-5}{1,-12}{2,8}", inv.InvNum, inv.InvDec, inv.InvPrice);
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
        }
    }
    
}
class Inventory
{

    public int InvNum { get; set; }
    public string InvDec { get; set; }
    public double InvPrice { get; set; }
}




