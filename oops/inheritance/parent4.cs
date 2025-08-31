class parent
{
	public void print()
	{
		System.Console.WriteLine(" from parent");
	}
}
class child : parent
{
	public void print()
	{
		System.Console.WriteLine("from child");
		base.print();
	}
}
class program
{
	public static void Main()
	{
		parent p=new parent();
		child c=new child();
		p.print();
		c.print();
	}
}
/* the ouput of this is 
 from parent
from child
from parent
*/
