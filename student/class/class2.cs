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
		for(int i=0;i<5;i++)
		{
			s[i].print();
		}
	}
}
/* the input of this is program is
1
shiva
32456
2
gani
1234567
3
jaanu
234567
4
abhi
234567
5
karthik
234567
this is the output
 1 shiva 32456
 2 gani 1234567
 3 jaanu 234567
 4 abhi 234567
 5 karthik 234567
 */
