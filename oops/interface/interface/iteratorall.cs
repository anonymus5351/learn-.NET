interface Iterator
{
	bool hasNext();
	int next();
}

	
class Stack : Iterator
{
	private int []s;
	int i;
	public Stack(int val)
	{
		s=new int[val];
	}
	public void push(int value)
	{
			s[i]=value;
			i++;
	}	
	public int pop()
	{
		return s[i--];
	}
	public bool isEmpty()
	{
		if(i>=0)
			return false;
		return true;
	}
	public bool hasNext()
	{
		return i>0;
	}
	public int next()
	{
		if(!hasNext())
		{
			return 0;
		}
		else
		{
			return s[--i];
		}
	}

}
class Queue : Iterator
{
	private int []Q;
	
	int front = 0;
	int rear=0;
	public Queue(int size)
	{
		Q=new int[size];
	}
	public void enqueue(int val)
	{
		Q[rear]=val;
		rear++;
		
	}
	
	public int dequeue()
	{
		return Q[front++];
	}
	
		
	public bool isempty()
	{
		
		if(front<rear)
			
			return false;
		return true;
	}
	public bool hasNext()
	{
		return front<rear;
	}
	public int next()
	{
		if(front>=rear)
		{
			return -1;
		}
		else
		{
			return Q[front++];
		}
	}
	

	
}	
class linkedlist : Iterator
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
	public bool hasNext()
	{
		return first!=null;
	}
	public int next()
	{
		if(first==null)
		{
			return -1;
		}
		int val = first.data;
        	first= first.next;
        	return val;
	}
	
}

class program
{
	public static void Main()
	{

		Stack s=new Stack(10);
		Queue Q=new Queue(10);
		linkedlist l=new linkedlist();
		Iterator itr;
		s.push(100);
		s.push(200);
		s.push(300);
		s.push(400);
		s.push(500);
		itr=s;
		while(itr.hasNext())
		{
			System.Console.WriteLine(itr.next());
		}
		Q.enqueue(10);
		Q.enqueue(20);
		Q.enqueue(30);
		Q.enqueue(40);
		Q.enqueue(50);
		itr=Q;
		while(itr.hasNext())
		{
			System.Console.WriteLine(itr.next());

		}
		l.insert(10);
		l.insert(20);
		l.insert(35);
		l.insert(45);
		l.insert(55);
		itr=l;
		while(itr.hasNext())
		{
			System.Console.WriteLine(itr.next());

		}
	}
}
/* this is the output of this program
500
400
300
200
100
10
20
30
40
50
10
20
35
45
55
*/
