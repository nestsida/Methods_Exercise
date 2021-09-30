using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Sum(30, 120));
            Console.WriteLine(Subtract(40, 60));
            Console.WriteLine(Multiply(30, 100));
            Console.WriteLine(Divide(30, 160));
            Console.WriteLine(Modulus(30, 100));

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"My name is {name} and my favorite color is {color}.");
            Console.WriteLine($"My favorite animal is {animal} and my favorite band is {band}.");

            Console.WriteLine("please enter your age: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your favorite number to add: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("The total is: ");
            int sum = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your age: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your favorite number to subtract: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The total is: ");
            int subtract = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your age: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your favorite number to multiply: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total is: ");
            int multiply = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your age: ");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your favorite number to divide: ");
            int a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total is: ");
            int divide = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your age: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your favorite number to see what remains: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total is: ");
            int modulus = int.Parse(Console.ReadLine());
        }
       public static int Sum(int x,int y)
        {
            int sum = x + y;
            return sum;
        }
        public static int Subtract(int a,int b)
        {
            int subtract = a - b;
            return subtract;
        }
        public static int Multiply(int num1,int num2)
        {
            int multiply = num1 * num2;
            return multiply;
        } public static int Divide(int a1,int a2)
        {
            int divide = a1 / a2;
            return divide;
        }
        public static int Modulus(int x1, int y1)
        {
            int modulus = x1 % y1;
            return modulus;
        }
    }
}
