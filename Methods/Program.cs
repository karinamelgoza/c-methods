using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("i am an argument and i am called from a method");
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
    }
}
