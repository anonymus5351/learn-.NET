class Math
{
	private int data;
	public Math(int val)
	{
		data=val;
	}
	public Math(){}
	public Math sum(Math m)
	{
		Math t=new Math();
		t.data=data+m.data;
		return (t);
	}
	public void print()
	{
		System.Console.WriteLine(data);
	}
}
class program
{
	public static void Main()
	{
		Math m1,m2,m3;
		m1=new Math(100);
		m2=new Math(200);
		m3=m1.sum(m2);
		m3.print();
	}
}
/* this is the output
300
*/
