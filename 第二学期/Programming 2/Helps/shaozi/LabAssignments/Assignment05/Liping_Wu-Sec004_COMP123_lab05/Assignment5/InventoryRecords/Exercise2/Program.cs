using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise2
{
	class Program
	{
		public static InventoryDB db;

		static void Main(string[] args)
		{

			string dataFile = Path.Combine(Directory.GetCurrentDirectory(), "inventory.txt");

			db = new InventoryDB(dataFile);
			ShowMenu();
			Console.WriteLine("Press any key to exit......");
			Console.ReadKey();
		}

		public static void DisplayMenu()
		{
			Console.WriteLine("=============================================================================");
			Console.WriteLine("|1. WriteInventoryRecords: add an inventory for online auction              |");
			Console.WriteLine("|2. ReadInventoryRecords: display all inventories for online auction          |");
			Console.WriteLine("|3. FindInventoryRecords : search inventory by number                       |");
			Console.WriteLine("|4. FindInventoryRecord2 : search inventories by minimum selling price      |");
			Console.WriteLine("|5. DeleteOneInventory: delete inventory by number                          |");
			Console.WriteLine("|0. End Program                                                             |");
			Console.WriteLine("=============================================================================");
		}

		public static void ShowMenu()
		{
			int choice;
			do
			{
				DisplayMenu();
				Console.WriteLine("Please enter your choice: ");
				choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1:
						WriteInventoryRecords();
						Console.WriteLine("\n");
						break;
					case 2:
						ReadInventoryRecords();
						Console.WriteLine("\n");
						break;
					case 3:
						FindInventoryRecords();
						Console.WriteLine("\n");
						break;
					case 4:
						FindInventoryRecord2();
						Console.WriteLine("\n");
						break;
					case 5:
						DeleteOneInventory();
						Console.WriteLine("\n");
						break;
				}
				Console.WriteLine("\nPress any key to display the menu and choice the operation......");
				Console.ReadKey();
			} while (choice != 0);
		}

		public static void WriteInventoryRecords()
		{
			Console.WriteLine("You are going to add an inventory at the online auction site.");
			Console.WriteLine(Inventory.getFieldsTitle());

			Inventory inv = new Inventory();
			Console.WriteLine("Enter inventory's item number >> ");
			inv.ItemNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter inventory's asking price >> ");
			inv.AskingPrice = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter inventory's descrpition >> ");
			inv.Description = Console.ReadLine();

			db.insert(inv);

		}

		public static void ReadInventoryRecords()
		{
			Inventory[] invs = db.select();
			Console.WriteLine(Inventory.getFieldsTitle());
			int count = 0;
			foreach (var inv in invs)
			{
				count += 1;
				Console.WriteLine(inv.ToString());
			}
			Console.WriteLine("Found Total {0} inventories at the online auction site.", count);
		}

		public static void FindInventoryRecords()
		{
			Console.WriteLine("You are going to find an inventory by item number.");
			Console.WriteLine("Enter inventory's item number for query >> ");
			var input = Console.ReadLine();
			int value = 0;
			if (int.TryParse(input, out value))
			{
				int itemNumber = value;
				Inventory inv = db.select(itemNumber);
				Console.WriteLine(Inventory.getFieldsTitle());
				if (inv.ItemNumber == itemNumber)
				{
					Console.WriteLine(inv.ToString());
				}
				else
				{
					Console.WriteLine("Not found the inventory with item number {0}", itemNumber);
				}
			}
		}

		public static void FindInventoryRecord2()
		{
			Console.WriteLine("You are going to find inventories by minimum selling price.");
			Console.WriteLine("Enter a minimum selling price for query >> ");
			double price = Convert.ToDouble(Console.ReadLine());
			Inventory[] invs = db.select(price);
			Console.WriteLine(Inventory.getFieldsTitle());
			int count = 0;
			foreach (var inv in invs)
			{
				count += 1;
				Console.WriteLine(inv.ToString());
			}
			Console.WriteLine("Found {0} inventories at the online auction site.", count);
		}

		public static void DeleteOneInventory()
		{
			Console.WriteLine("You are going to delete an inventory by item number.");
			Console.WriteLine("Enter inventory's item number for delete >> ");
			int itemNumber = Convert.ToInt32(Console.ReadLine());
			if (db.delete(itemNumber))
			{
				Console.WriteLine("deleted successfully.");
			}
			else {
				Console.WriteLine("Not found it at the online auction site.");
			}
		}

	}
}
