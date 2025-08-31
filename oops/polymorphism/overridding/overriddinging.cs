class parent
{
	public virtual void print()
	{
		System.Console.WriteLine(" from parent");
	}
}
class child : parent
{
	public override void print()
	{
		System.Console.WriteLine("from child");
	
	}
}
class program
{
	public static void Main()
	{
		parent p=new parent();
    p.print();
		p=new child();
		
		p.print();
	}
}
/* this is the output
from parent
from child

*/
