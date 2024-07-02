namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[,] arr = { { 1, 2, 3 }, { 7,8,9 } };

            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
            object[] arr1 = { "C", 1200, true, "Welcome", 12.34 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            
        }
    }
}
