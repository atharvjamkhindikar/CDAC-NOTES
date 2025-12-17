
namespace HelloWorld
{
    internal class Program
    {
           
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome To The .Net World AJ...!");
            Program.Addition(5,10);
            Console.WriteLine(Addition(5,10));
        }

        private static int Addition(int x,int y)
        {
             return x + y;
             
            throw new NotImplementedException();
        }
    }
}
