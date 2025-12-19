namespace Swapping_Demo
{
    internal class Math
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Swapping of Numbers via Debug Mode----");
            Math m1= new Math();
            int a = 10, b = 20;
            Console.WriteLine($"Before Swapping: a = {a}, b = {b}");
            m1.swap(ref a,ref b);  
            Console.WriteLine($"After Swapping: a = {a}, b = {b}");
        }

        public void swap(ref int x, ref int y)     // pass by reference
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
