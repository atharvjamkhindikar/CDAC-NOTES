using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldStd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine("AJ >> Atharv !");
            
            Console.WriteLine("Enter Num 1 :");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num 2 :");
            int y= Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Addition is "+Addition(x, y));
          
        }

        private static int Addition(int x,int y)
        {
            return x+ y;
        }
    }
}
