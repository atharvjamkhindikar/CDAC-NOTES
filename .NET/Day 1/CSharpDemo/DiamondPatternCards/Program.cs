
//        *
//    *       *
//*               *
//    *       *
//        *


namespace DiamondPatternCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamond Playing Card Pattern");

            int n = 3;              // height of upper half (including middle)

            // upper half (including middle line)
            for (int i = 0; i < n; i++)
            {
                // leading spaces
                for (int j = 0; j < n - i - 1; j++)
                    Console.Write(" ");

                // first star
                Console.Write("*");

                if (i > 0) // for rows after the first, print inner spaces + second star
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                        Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // lower half
            for (int i = n - 2; i >= 0; i--)
            {
                // leading spaces
                for (int j = 0; j < n - i - 1; j++)
                    Console.Write(" ");

                // first star
                Console.Write("*");

                if (i > 0)
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                        Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();


            }
        }
    }
}