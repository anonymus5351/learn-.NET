class program
{
	public static void Main()
	{
		int search;
		Items item=new Items();
		item.add(100);
		item.add(200);
		item.add(300);
		item.add(400);
		item.print();		
	}
}
class Items
{
	private int []a=new int[5];
	int i=0;
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
/* the output of this program is 
100
200
300
400
0
*/
}
