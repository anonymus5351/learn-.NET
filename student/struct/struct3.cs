struct student 
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
		System.Console.WriteLine(" {0} {1} {2}",pid,pname,price);
	}
}
class program
{
	public static void Main()
	{
		student s1,s2;
		s1=new student();
		s2=s1;
		s1.read();
		s2.print();
	}
}
/* the input of this is 
1
shiva
23456
this is the output of this program
 0  0
*/
