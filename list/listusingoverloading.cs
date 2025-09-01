class program
{
	public static void Main()
	{
		
		Items item=new Items();
    item.create(5);
		item.add(100);
		item.add(200);
		item.add(300);
		item.add(400);
		item.print();		
	}
}
class Items
{
 	private int []a;
 	int i=0;
 	public void create(int val)
 	{
		a=new int[val];
	}
	public void create()
	{
		a=new int[10];
	}
	public void add(int value)
	{
		a[i]=value;
		i++;
	}
	public void print()
	{
		for(i=0;i<5;i++)
		{
			System.Console.WriteLine(a[i]);
		}
	}
}
/* the output of this program
100
200
300
400
0
*/
