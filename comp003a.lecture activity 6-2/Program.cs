namespace comp003a.lecture_activity_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeCalculator calculator = new ShapeCalculator();
            Console.WriteLine($"Circle area: {calculator.CalculateArea(5)}");
            Console.WriteLine($"rectangle area: {calculator.CalculateArea(5, 10)}");
            Console.WriteLine($"triangle area: {calculator.CalculateArea(5, 10, true)}");


            Shape myCircle = new circle(7);

            Shape myRectangle = new Rectangle(4, 8);

            myCircle.DisplayArea();
            myRectangle.DisplayArea();
        }
    }
}
