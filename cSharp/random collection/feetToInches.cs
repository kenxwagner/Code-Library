using System; 				//Importing namespace

class Test					//Class declaration
{
	static void Main()		//Method declaration
	{
		Console.WriteLine (FeetToInches (30));
		Console.WriteLine (FeetToInches (100));
		Console.WriteLine (FeetToInches (12));
		Console.WriteLine (FeetToInches (300));
		Console.WriteLine (FeetToInches (5280));
		Console.WriteLine (FeetToInches (43560));
	}								//End of method
	static in FeetToInches (int feet)
	{
		int inches = feet * 12;
		return inches;
	}
}									//End of class