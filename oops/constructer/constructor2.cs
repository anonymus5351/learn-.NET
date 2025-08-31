class myclass{
	public myclass(int val)
	{
		System.Console.WriteLine("from constructor {0}",val);
	}
}
class program
{
	public static void Main()
	{
		myclass mc=new myclass(10);
	}
}
/* this is the output
from constructor 10
*/
