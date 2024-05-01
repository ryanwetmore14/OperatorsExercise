namespace OperatorsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            int math = a * b;
            int addition = a + b;
            int subtractition = a - b;

            Console.WriteLine($"{a} / {b}  is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle");

            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

            Console.WriteLine("Hello World my name is Ryan Wetmore and we just found the radius us our circle!");




        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(2, radius);

            return area;

        }


    }
}

