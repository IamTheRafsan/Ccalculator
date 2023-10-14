namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Total how many numbers to be calculated for you?: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());

            int res = a;

            for (int x = 0; x < num - 1; x++)
            {
                string symbol = Console.ReadLine();
                int b = Convert.ToInt32(Console.ReadLine());

                if (symbol.Equals("+"))
                {
                    res = res + b;
                }
                if (symbol.Equals("-"))
                {
                    res = res - b;
                }
                if (symbol.Equals("*"))
                {
                    res = res * b;
                }
                if (symbol.Equals("/"))
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        break;
                    }
                    res = res / b;

                }
            }

            Console.WriteLine("Result: " + res);





        }
    }
}