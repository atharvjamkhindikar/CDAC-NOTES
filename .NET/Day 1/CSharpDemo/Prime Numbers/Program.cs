namespace Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Prime Numbers ");

            Console.WriteLine("Inter num to check its Prime or not ");
            int x = Convert.ToInt32(Console.ReadLine());

            if(CheckPrimes(x))
            {
                Console.WriteLine(x + " is a Prime Number");
            }
            else
            {
                Console.WriteLine(x +" is not a Prime Number");
            }

        }
        private static bool CheckPrimes(int x)
        {
            if (x <= 1)
            {
                return false;
            }
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}



