using System.Transactions;

namespace Reverse_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, rem,rev=0;
            Console.Write("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            while(number>0)
            {
                rem=number%10;
                rev = (rev * 10) + rem;
                number = number / 10;

            }
            Console.WriteLine("The number {0} reverse number is {1}",temp,rev);
        }
    }
}