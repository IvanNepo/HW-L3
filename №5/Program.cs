namespace _5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Rainbow colour number: ");
            string input = Console.ReadLine();
            int ColorNumber = int.Parse(input);
            switch (ColorNumber)

            {
                case 1:
                    Console.WriteLine("Red");
                    break;
                case 2:
                    Console.WriteLine("Orange");
                    break;
                case 3:
                    Console.WriteLine("Yellow");
                    break;
                case 4:
                    Console.WriteLine("Green");
                    break;
                case 5:
                    Console.WriteLine("Light Blue");
                    break;
                case 6:
                    Console.WriteLine("Blue");
                    break;
                case 7:
                    Console.WriteLine("Purple");
                    break;
                default:
                    Console.WriteLine("There is no such colour in the rainbow");
                    break;


            }

        }
    }
}

