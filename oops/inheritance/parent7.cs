class parent
{
	public void print()
	{
		System.Console.WriteLine(" from parent");
	}
}
class child : parent
{
	public new void print()
	{
		System.Console.WriteLine("from child");
		base.print();
	}
}
class program
{
	public static void Main()
	{
		
		child c=new child();
		
		c.print();
	}
}
/* this is the output
from child
from parent
*/
