namespace SwitchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch= 'A';
            switch(ch)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break;
            }
        }
    }
}
