using System;

namespace Polymorphism
{
	class Program
	{
		static void Main(string[] args)
		{
			printerNumberInput:
			PrinterWindows printer;
			Console.WriteLine("Choose a Printer: ");
			Console.WriteLine("1. Epson");
			Console.WriteLine("2. Canon");
			Console.WriteLine("3. LaserJet");
   
			Console.Write("Printer Number[1..3]: ");
			int printerNumber = Convert.ToInt32(Console.ReadLine());
   
			if (printerNumber == 1)
			{
				printer = new Epson();
			}
			else if (printerNumber == 2)
			{
				printer = new Canon();
			}
			else if (printerNumber == 3)
			{
				printer = new LaserJet();
			}
			else
			{
			Console.WriteLine("Sorry. The number you input has not been recorded. Try again.");
			goto printerNumberInput;
			}
   
			printer.Show();
			printer.Print();
	   
			Console.ReadKey();
		}
	}
 
	public class PrinterWindows
	{
		public string printerName {get;set;}
		public string displayDimention {get;set;}
  
		public virtual void Show()
		{
			Console.WriteLine("{0} display dimension: {1}", printerName, displayDimention);
		}
		
		public virtual void Print()
		{
			Console.WriteLine("{0} printer printing....", printerName);
		}
	}
	
	public class Epson : PrinterWindows
	{
		public Epson()
		{
			printerName = "Epson";
			displayDimention = "10*11";
		}
	}
 
	public class Canon : PrinterWindows
	{
		public Canon()
		{
			printerName = "Canon";
			displayDimention = "9.5*12";
		}
	}
 
	public class LaserJet : PrinterWindows
	{
		public LaserJet()
		{
			printerName = "LaserJet";
			displayDimention = "12*12";
		}
	}
}
