namespace Perfect_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, number;
            Console.Write("Enter the number wamt to check: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i=1; i<number; i++)
            {
                if (number % i == 0)
                {
                    sum+=i;
                }
            }
            if (number == sum)
            {
                Console.WriteLine("The number {0} is a perfect number",number);
            }
            else
            {
                Console.WriteLine("The number {0} is not a perfect number", number);
            }
        }
    }
}