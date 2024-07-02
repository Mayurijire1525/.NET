namespace OperatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b;
            b = a++;
           
            Console.WriteLine("a-{0} and b={1}",a,b);
            int m = 5, n=0;
            m += 5;
            m *= 6;
            Console.WriteLine("m-{0} and n={1}", m, n);
        }
    }
}
