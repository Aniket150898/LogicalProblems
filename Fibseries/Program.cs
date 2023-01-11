namespace Fibseries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("***PrimeNumber***");
            Console.WriteLine("Enter the number");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                Console.WriteLine("The number is not a Prime Number");
            }
            else
            {
                Console.WriteLine("It is Prime Number");
            }
        }

    }
}