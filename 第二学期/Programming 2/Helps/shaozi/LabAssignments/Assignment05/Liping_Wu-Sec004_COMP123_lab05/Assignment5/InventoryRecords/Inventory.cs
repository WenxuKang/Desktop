using System;

public class Inventory
{
	// property
	public int ItemNumber { get; set; }
	public String Description { get; set; }
	public double AskingPrice { get; set; }
	
	public Inventory()
	{
		//item number, description, and asking price
	}
	public Inventory(int itemNumber, String description, double askingPrice)
	{
		//item number, description, and asking price
		this.ItemNumber = itemNumber;
		this.Description = description;
		this.AskingPrice = askingPrice;
	}

	//ToString to display instance data.
	public override string ToString()
	{
		return String.Format("{0} | {1} | {2}", this.ItemNumber, this.AskingPrice, this.Description);
	}


}
