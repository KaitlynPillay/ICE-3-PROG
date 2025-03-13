namespace ICE_3_PROG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Rectangle
            Rectangle rectangle = new Rectangle("Rectangle", 5, 15);
            rectangle.Display();
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");

            // Create a Circle
            Circle circle = new Circle("Circle", 6);
            circle.Display();
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            Console.ReadLine();
        }
    }
}

