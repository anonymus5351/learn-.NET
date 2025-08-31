class parent
{
    public virtual void print()
  {
      System.Console.WriteLine("from parent print");
    }
}
class child : parent
{
public override void print()
{
    System.Console.WriteLine("from child print");
}
public void print(int val)
{
System.Console.WriteLine("from child print{0}",val);
}
}
class program
{
public static void Main()
{
  parent p;
  p=new child();
  p.print();
  child c;
  (p as child).print(100);
}
}
/* the output of this is 
from child print
from child print100
*/
