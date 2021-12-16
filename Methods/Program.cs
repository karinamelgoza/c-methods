using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteSomething();
            //WriteSomethingSpecific("i am an argument and i am called from a method");

            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(3, 7));
            Console.WriteLine(Divide(25 , 13));
            Console.Read();
        }
        // access modifier (static) return type method name (parameters)
        public static void WriteSomething()
        {
            Console.WriteLine("i am called from a method");

        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
