class myclass{
	public myclass()
	{
		System.Console.WriteLine("from constructor");
	}
	public myclass(int val)
	{
		System.Console.WriteLine("from constructor{0}",val);
	}
}
class program
{
	public static void Main()
	{
		myclass mc=new myclass();
		myclass mc1=new myclass(100);
	}
}
/* this is the output
from constructor
from constructor100;
*/
