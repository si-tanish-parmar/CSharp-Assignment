namespace ShapeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle
            {
                Radius = 5
            };

            Rectangle rectangle = new Rectangle
            {
                Width = 6,
                Height = 8
            };

            Triangle triangle = new Triangle
            {
                Base = 5,
                Height = 4,
                Side1 = 3,
                Side2 = 4,
                Side3 = 5
            };

            Console.WriteLine("Circle:");
            circle.DisplayShapeDetails();

            Console.WriteLine("\nRectangle:");
            rectangle.DisplayShapeDetails();

            Console.WriteLine("\nTriangle:");
            triangle.DisplayShapeDetails();
        }
    }
}