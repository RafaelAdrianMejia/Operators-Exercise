namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int add = 1 + 1;
            int sub = 1 - 1;
            int mul = 1 * 1;
            int div = 1 / 1;
            int mod = 1 % 1;

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            //PrintAreaOfCircle();

            // var is implicit type inferrence (more on this later)
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); // ouputs ?
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");

            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");
        }
    }
}
