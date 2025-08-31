class myclass{
	public myclass()
	{
		System.Console.WriteLine("from constructor");
	}
}
class program
{
	public static void Main()
	{
		myclass mc=new myclass();
	}
}
/* this is the output
from constructor
*/
