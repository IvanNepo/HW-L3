namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int num = int.Parse(Console.ReadLine());
            if (num %2==0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");

            }
        }
    }
}
