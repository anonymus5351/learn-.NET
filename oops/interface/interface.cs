interface Imath2024
{
	int sum(int x,int y);
}
interface Imath2025 : Imath2024
{
	int sub(int x,int y);
}
interface Imath2026
{
	int mult(int x,int y);
}
class math : Imath2025,Imath2026
{
	public int sum(int x,int y)
	{
		return(x+y);
	}
	public int sub(int x,int y)
	{
		return(x-y);
	}
	public int mult(int x,int y)
	{
		return(x*y);
	}
	public int div(int x,int y)
	{
		return(x/y);
	}
}
class program
{
	public static void Main()
	{
		Imath2024 m1;
		Imath2025 m2;
		Imath2026 m3;
		math m=new math();
		System.Console.WriteLine(m.sum(100,200));
		System.Console.WriteLine(m.sub(5000,100));
		System.Console.WriteLine(m.mult(100,2));
		System.Console.WriteLine(m.div(300,2));
		m1=m;
		System.Console.WriteLine(m1.sum(5000,100));
		m2=m;
		System.Console.WriteLine(m2.sum(10000,1000));
		System.Console.WriteLine(m2.sub(100,2));
		m3=m;
		System.Console.WriteLine(m3.mult(500,2));
		System.Console.WriteLine((m3 as math).div(500,2));
	}
}

/* the output of this is
300
4900
200
150
5100
11000
98
1000
250
*/
