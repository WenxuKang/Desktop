using System;

public class InventoryDB
{
	// property
	public String DataFile { get; set; }

	public InventoryDB()
	{
		this.DataFile = "c:\\datafiles\\auctionitems.txt";
	}

	public InventoryDB(String dataFile)
	{
		this.DataFile = dataFile;
	}

	//ToString to display instance data.
	public override string ToString()
	{
		return String.Format("Inventory data file is {0}", this.DataFile);
	}



}
