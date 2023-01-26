// exercise 1 
// exercise 2

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var a = 17;
            var b = 4;
            var name = "aleman";
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");


            Console.WriteLine("please enter radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine(AreaOfCircle(radius));
        }


        var radius = double.Parse(Console.ReadLine());
        public static double AreaOfCircle(double radius)


        {


            var area = Math.PI * Math.Pow(radius, 2);
            return area;


        }
    }
}
