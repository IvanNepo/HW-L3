namespace HW3
{
    internal class EnumDemo 
    {
        enum month { Janury,February,March,April,May,June,July,August,September,October,November,December};
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month number: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 12)
                Console.WriteLine("Incorrect number");
        else
                Console.WriteLine("Month at number {0}: {1}", n, (month)(n - 1));
            Console.ReadKey();
                }
    }
}
