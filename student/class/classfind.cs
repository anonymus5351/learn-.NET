class student 
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
	public int get()
	{
		return(pid);
	}
}
class program
{
	public static void Main()
	{
		student []s=new student[5];
		
		for(int i=0;i<5;i++)
		{
			s[i]=new student();
			s[i].read();
		}
		int search=int.Parse(System.Console.ReadLine());
		for(int i=0;i<5;i++)
		{
			if(search==s[i].get())
			{
				s[i].print();
				break;
			}
			if(i==4)
			{
				System.Console.WriteLine("enter element not fount");
			}
		}
	}
}
/* the output of this is 
1
shiva
1234
2
gani
1234
3
jaanu
1234
4
abhi
1234
5
karthik
1234
this is the output
2
 2 gani 1234
*/
