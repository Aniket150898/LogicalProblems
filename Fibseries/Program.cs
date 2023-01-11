namespace Fibseries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, n;
            Console.WriteLine("***Finding Perfect Number***");
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            n = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
            }
        }

    }
}