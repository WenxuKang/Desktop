using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryRecords

{
	//Create a program named WriteInventoryRecords that allows you to enter data for items
	//you sell at an online auction site and saves the data to a file. Create an Inventory class
	//that contains fields for item number, description, and asking price.

	class WriteInverntoryRecords
	{
		static void Main()	
		{
			try
			{
				//FileStream outFile = new FileStream("SomeText.txt", FileMode.Create, FileAccess.Write);
				FileStream outFile = new FileStream(@"c:\datafiles\auctionitems.txt", FileMode.Append, FileAccess.Write);

				StreamWriter writer = new StreamWriter(outFile);
				// Console.Write("Enter some text: >> ");
				string text;
				Console.Write("Enter some names: >> ");
				for (int i = 0; i < 3; i++)
				{
					text = Console.ReadLine();
					Console.WriteLine(text);
				}//end loop
				 //writer.Close();
				 //outFile.Close();
			}//end try
			catch (Exception ex)
			{
				Console.WriteLine("error:" + ex.Message);
			}
			//writer.WriteLine(text);
			// Error occurs if the next two statements are reversed

			finally
			{
				//writer.Close();
				//outFile.Close();
			}


		}
	}
}
