namespace Labb_4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(5);
            Console.WriteLine(circle1.GetArea());
            Console.WriteLine(circle2.GetArea());
        }
    }
}
