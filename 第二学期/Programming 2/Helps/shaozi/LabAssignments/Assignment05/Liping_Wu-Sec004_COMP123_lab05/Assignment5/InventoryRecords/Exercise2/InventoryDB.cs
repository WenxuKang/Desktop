using System;
using System.IO;
using System.Collections.Generic;


public class InventoryDB
{
	// property
	public String DataFile { get; set; }

	public InventoryDB(bool reset = false)
	{
		this.DataFile = "c:\\datafiles\\auctionitems.txt";
		this.createDBFile(reset);
	}

	public InventoryDB(String dataFile, bool reset=false)
	{
		this.DataFile = dataFile;
		this.createDBFile(reset);
	}

	private void createDBFile(bool reset)
	{
		if (! File.Exists(this.DataFile))
		{
			reset = true;
		}
		// reset the data file to only include field's title without any real rows yet.
		if (reset)
		{
			File.WriteAllLines(this.DataFile, new string[] { Inventory.getFieldsTitle()});
		}

	}

	//ToString to display instance data.
	public override string ToString()
	{
		return String.Format("Inventory data file is {0}", this.DataFile);
	}

	public bool insert(Inventory row)
	{
		FileStream outFile = new FileStream(this.DataFile, FileMode.Append, FileAccess.Write);
		StreamWriter writer = new StreamWriter(outFile);
		writer.WriteLine(row.ToRowString());
		writer.Close();
		outFile.Close();

		return true;
	}

	public Inventory[] select(double miniPrice=0)
	{
		FileStream inFile = new FileStream(this.DataFile, FileMode.Open, FileAccess.Read);
		StreamReader reader = new StreamReader(inFile);
		reader.ReadLine(); // jump the first line as we know it is the title not the real data

		List<Inventory> invs = new List<Inventory>();
		string recordIn;
		recordIn = reader.ReadLine();
		while (recordIn != null)
		{
			Inventory tempInv = new Inventory(recordIn);
			if (miniPrice == 0 || tempInv.AskingPrice >= miniPrice)
			{
				invs.Add(tempInv);
			}			
			recordIn = reader.ReadLine();
		}
		reader.Close();
		inFile.Close();
		return invs.ToArray();
	}
	public Inventory select(int itemNumber)
	{
		FileStream inFile = new FileStream(this.DataFile, FileMode.Open, FileAccess.Read);
		StreamReader reader = new StreamReader(inFile);
		reader.ReadLine(); // jump the first line as we know it is the title not the real data

		Inventory inv = new Inventory();
		string recordIn;
		recordIn = reader.ReadLine();		
		while (recordIn != null)
		{
			inv.Load(recordIn);
			if (inv.ItemNumber == itemNumber)
			{
				// found the matched inventory, should return it right now
				break;
			}
			recordIn = reader.ReadLine();
			inv.Reset();
		}
		reader.Close();
		inFile.Close();
		return inv;
	}

	public bool delete(int itemNumber)
	{
		string tempFile = Path.GetTempFileName();
		var sw = new StreamWriter(tempFile);
		FileStream inFile = new FileStream(this.DataFile, FileMode.Open, FileAccess.Read);
		StreamReader reader = new StreamReader(inFile);
		sw.WriteLine(reader.ReadLine()); // jump the first line as we know it is the title not the real data

		bool deleted = false;
		Inventory inv = new Inventory();
		string recordIn;
		recordIn = reader.ReadLine();
		while (recordIn != null)
		{
			inv.Load(recordIn);
			if (inv.ItemNumber == itemNumber)
			{
				// found the matched inventory to be deleted, so we skip copying it to the temp path
				deleted = true;				
			}
			else
			{
				sw.WriteLine(recordIn);
			}
		

			recordIn = reader.ReadLine();
			inv.Reset();
		}
		reader.Close();
		inFile.Close();

		sw.Close();
		if (deleted)
		{
			File.Delete(this.DataFile);
			// copy the temp path to override the database data file, so we will delete the matched inventory 
			File.Move(tempFile, this.DataFile);
		}
		else {
			File.Delete(tempFile);
		}
		return deleted;
	}
}
