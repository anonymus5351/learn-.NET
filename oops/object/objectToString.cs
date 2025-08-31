class product 
{
	private int pid;
	private string pname;
	private double price;
	public void read()
	{
		pid=int.Parse(System.Console.ReadLine());
		pname=System.Console.ReadLine();
		price=double.Parse(System.Console.ReadLine());
	}
	public void print()
	{
		System.Console.WriteLine("{0} {1} {2}",pid,pname,price);
	}
	public override string ToString()
	{
	    return pid + " " + pname + " " + price;
	}

}
class employee 
{
	private int eid;
	private string ename;
	private double salary;
	public void read()
	{
		eid=int.Parse(System.Console.ReadLine());
		ename=System.Console.ReadLine();
		salary=double.Parse(System.Console.ReadLine());
	}
	public void print()
	{
		System.Console.WriteLine("{0} {1} {2}",eid,ename,salary);
	}
	public override string ToString()
	{
	    return eid + " " + ename + " " + salary;
	}

}
class program
{
	public static void Main()
	{
		Items item=new Items(5);
		product p=new product();
		employee e=new employee();
		p.read();
		e.read();
		item.Add(p);
		item.Add(e);
		item.Add(100);
		item.Add(22.22);
		item.Add("ravi");
		for(int i=0;i<5;i++)
		{
			object o;
			o=item.get();
			System.Console.WriteLine(o.ToString());
		}
	}
}
class Items
{
	private object []p;
	int i;
	public Items(int size)
	{
		p=new object[size];
	}
	public void Add(object r)
	{
		p[i]=r;
		i++;
	}
  public object get()
	{
		return p[--i];
	}

}
/* this is the input
1
shiva
2345
2
ravi
23456
this is the output
ravi
22.22
100
2 ravi 23456
1 shiva 2345 */
