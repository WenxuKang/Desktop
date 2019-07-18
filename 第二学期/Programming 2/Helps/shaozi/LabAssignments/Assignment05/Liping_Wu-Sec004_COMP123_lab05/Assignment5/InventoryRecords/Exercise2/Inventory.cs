using System;

public class Inventory
{
	// property
	public int ItemNumber { get; set; }
	public string Description { get; set; }
	public double AskingPrice { get; set; }

	const char DELIM = ',';

	public Inventory()
	{
		//item number, description, and asking price
	}
	public Inventory(int itemNumber, double askingPrice, string description )
	{
		//item number, description, and asking price
		this.ItemNumber = itemNumber;
		this.AskingPrice = askingPrice;
		this.Description = description;
	}

	public Inventory(string row)
	{
		this.Load(row);
	}

	public void Load(string row)
	{
		//load the inventory from one database row string, csv format: [itemNumber],[askingPrice],[Description]
		string[] fields = row.Split(DELIM);
		this.ItemNumber = Convert.ToInt32(fields[0]);
		this.AskingPrice = Convert.ToDouble(fields[1]);
		this.Description = fields[2].Replace("0x2c", ",");
	}

	public void Reset()
	{
		this.ItemNumber = 0;
		this.AskingPrice = 0;
		this.Description = "";
	}

	//ToString to display instance data.
	public override string ToString()
	{
		return String.Format("{0, 12} | {1, 12} | {2, 40}", this.ItemNumber, this.AskingPrice, this.Description);
	}

	public string ToRowString()
	{
		return String.Format("{0, 12},{1, 12},{2, 40}", this.ItemNumber, this.AskingPrice, this.Description.Replace(",", "0x2c"));
	}

	public static string getFieldsTitle()
	{
		return String.Format("{0, 12} | {1, 12} | {2, 40}", "Item Number", "Asking Price", "Description");
	}

}
