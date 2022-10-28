namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,count=0,i;
            Console.Write("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("The number {0} is a Prime Number", number);
            }
            else
            {

                Console.WriteLine("The number {0} is not a Prime Number", number);
            }
          

        }
    }
}