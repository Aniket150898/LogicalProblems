namespace Fibseries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***ReverseNumber***");
            Console.WriteLine("Enter the Number to check Reverse number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Reverse = 0;
            while (Number != 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine(Reverse + " is reverse number");
        }

    }
}