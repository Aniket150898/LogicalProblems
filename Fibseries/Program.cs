namespace Fibseries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***FibseriesCode***");
            int a = 0, b = 1, c;
            Console.WriteLine("Enter the number:");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + " " + b + " ");

            for ( int i = 2; i < Num; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}