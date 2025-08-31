class parent
{
	public parent(int val)
	{
		System.Console.WriteLine("from parent {0}",val);
	}
	public parent()
	{
		System.Console.WriteLine("from parent");
	}
}
class child : parent
{
	public child(int val):base(val)
	{
		System.Console.WriteLine("from child{0}",val);
	}
}
class program
{
	public static void Main()
	{
		parent p=new parent(100);
		child c=new child(200);
	}
}
/* the output of this is 
from parent100
from child 200
from parent 200
