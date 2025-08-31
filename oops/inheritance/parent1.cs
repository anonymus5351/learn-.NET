class parent
{
	public parent()
	{
		System.Console.WriteLine("from parent");
	}
}
class child : parent
{
	public child()
	{
		System.Console.WriteLine("from child");
	}
}
class program
{
	public static void Main()
	{
		parent p=new parent();
		child c=new child();
	}
}
/* the output of this is 
from parent 
from parent 
from child
