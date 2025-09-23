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
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(6, 8, 10);    
            Console.WriteLine(triangle1.GetArea());
            Console.WriteLine(triangle2.GetArea());
            

        }
    }
}
