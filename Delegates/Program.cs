using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Joiner joinObject = new Joiner("Para");

            MyDelegate stringFormat = PrintUpper;
            stringFormat += PrintLower;
            stringFormat += joinObject.JoinAndPrint;

            stringFormat("Teste");
            
        }

        public static void PrintUpper(string str) 
        {
            Console.WriteLine( str.ToUpper());
        }
        public static void PrintLower(string str) 
        {
            Console.WriteLine( str.ToLower());
        }
    }
}
