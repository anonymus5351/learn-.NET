class linkedlist
{
	private class node
	{
		public int data;
		public node next;
		
		public node(int val)
		
		{
			data =val;
			next =null;
		}
	}
	
	private node first, last;
	public linkedlist()
	{
		first=null;
		last=null;

	}
	
	public void insert(int val)
	{
		node newnode=new node(val);
		if(first ==null)
		{
			first=last=newnode;
		}
		else
		{
			last.next=newnode;
			last=newnode;
		}
	}
	public int delete()
	{
		if(first == null)
		{
			System.Console.WriteLine("empty");
			return -1;
		}
		else
		{
			int val = first.data;
			first = first.next;
			return val;
		}
	}
	public bool isempty()
	{
		return first == null;
	}
}

class lap
{
	public static void Main()
	{


		linkedlist l=new linkedlist();
		l.insert(10);
		l.insert(20);
		l.insert(35);
		l.insert(45);
		l.insert(55);
		while(!l.isempty())
		{
			System.Console.WriteLine(l.delete());

		}
	}
}
/* this is the output of the program
10
20
35
45
55
*/
