namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.Write("Emter a number u want the Fobonacci Serise");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (int i=2; i<number; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}