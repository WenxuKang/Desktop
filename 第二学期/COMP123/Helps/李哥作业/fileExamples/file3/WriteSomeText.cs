using System;
using System.IO;
class WriteSomeText
{
    static void Main()
    {
        try { 
        //FileStream outFile = new
        //   FileStream("SomeText.txt", FileMode.Create,
        //      FileAccess.Write);
        ////FileStream outFile = new
        ////FileStream("Number.txt", FileMode.Create,
        //// FileAccess.Write);
        FileStream outFile = new
           FileStream(@"c:\datafile\name.txt", FileMode.Create,
              FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);
        //Console.Write("Enter some text >> ");
        //string text = Console.ReadLine();
        string text;
        Console.WriteLine("Enter some names >>");
        for (int i = 0; i < 3; i++)
        {
            text = Console.ReadLine();
            writer.WriteLine(text);
        }//end loop
            writer.Close();
            outFile.Close();
        }//end try
    catch(Exception ex){
        Console.WriteLine(  "error:"+ex.Message);
            

        }
       // writer.WriteLine(text);

        // Error occurs if the next two statements are reversed
      //////  writer.Close();
      //////outFile.Close();
   }
}
