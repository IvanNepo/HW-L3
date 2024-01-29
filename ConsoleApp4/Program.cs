namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temperature: ");
            int Temperature = int.Parse(Console.ReadLine());
            if (Temperature > -5)
            {
                Console.WriteLine("Warm");

            }
            else if (Temperature > -20)
            {
                Console.WriteLine("Fine");
            }
            else {
                Console.WriteLine("Cold");
                    }
            Console.ReadKey();
        }
    }
}
