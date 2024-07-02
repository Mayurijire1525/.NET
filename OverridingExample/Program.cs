namespace OverridingExample
{
    internal class Program
    {
        void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        void add(int x,int y, int z)
        {
            Console.Write(x + y + z);
        }
        void add(float x,int y)
        {
              Console.WriteLine(y + x);
        }
        void add(float x,float y)
        {
            Console.WriteLine(x+y);
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.add(1,2);
            Employee employee=new Employee();
            employee.Accept(2000);
            employee.display();
           
        }
    }
}
