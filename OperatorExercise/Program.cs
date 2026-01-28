namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            // Exercise 1
            // Variable Declaration
            int a = 17;
            int b = 4;

            // Performing operations and storing into new variables
            int sum = a + b;
            int difference = a - b;
            int product = a * b;

            // Division and Modulus operation
            int quotient  = a / b;
            int remainder = a % b;

            // Displaying Result:
            Console.WriteLine($"{a} + {b} is: {sum}.");
            Console.WriteLine($"{a} - {b} is: {difference}.");
            Console.WriteLine($"{a} * {b} is: {product}.");
            Console.WriteLine($"{a} / {b} is:  {quotient} with a remainder of {remainder}.");
            Console.WriteLine("\n=======================================");
            Console.WriteLine("In the below steps, we will be calculate the Area of a Circle, with the radius provided by user input.");
            Console.WriteLine("=======================================\n");
            
            // Calling the method for Exercise 2
            PrintAreaOfCircle();

            /*
            // TEST FOR THE PRE-INCREMENT ASSIGNEMNT OPERATOR
            int i = 3;
            int j = 4;
            int k = ++i * j++;  // 'i' becomes "4" and 'j' remains "4" until the value has been assigned to 'k'.

            Console.WriteLine(k); // 16
            */
        }

        // Exercise 2 Function...
        // Calculate Area of a Circle with the radius value provided
        static double AreaOfCircle(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2));
        }


        // This function retrives the user input of radius and displays the Area (with rounded to 3) by calling 'AreaOfCircle' function 
        public static void PrintAreaOfCircle()
        {
            string? radius;
            double radiusAsDouble;
            do
            {
                Console.WriteLine("Please provide radius for a circle in a numerical format");
                radius = Console.ReadLine();
            }while(!double.TryParse(radius, out radiusAsDouble));

            Console.WriteLine($"The area of circle with radius of {radius} is {Math.Round(AreaOfCircle(radiusAsDouble), 3)}.");
        }
    }
}
