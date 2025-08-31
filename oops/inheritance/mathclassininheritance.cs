class Math2025
{
	public int sum(int x,int y)
	{
		return(x+y);
	}
	protected int mult(int x,int y)
	{
		return(x*y);
	}
}
class Math2026 : Math2025
{
	public int div(int x,int y)
	{
		return(x/y);
	}
	public int multiply(int x,int y)
	{
		return mult(x,y);
	}
}
class program
{
	public static void Main()
	{
		Math2025 m1=new Math2025();
		Math2026 m2=new Math2026();
		System.Console.WriteLine(m1.sum(10,20));
    System.Console.WriteLine(m1.mult(20,2)); //we can not say like this because we get an error when we say like this
		System.Console.WriteLine(m2.sum(1000,2000));
		System.Console.WriteLine(m2.div(100,2));
    System.Console.WriteLine(m2.mult(20,2)); //we can not say like this because we get an error when we say like this
		System.Console.WriteLine(m2.multiply(100,2));
	}
}
/* the output will be 
30
3000
50
200
*/
