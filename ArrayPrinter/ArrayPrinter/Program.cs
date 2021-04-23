using System;

namespace ArrayPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrayBegin = "[ ";
            string arrayEnd = "]";
            string arrayString = "";


            while (true) {
                string item = Console.ReadLine();
                if (item.Equals("-1")) {
                    break;
                }
                else {
                    arrayString += "\""+item+"\""+", ";
                }
            }
            Console.WriteLine(arrayBegin+arrayString+arrayEnd);
            Console.ReadKey();
        }
    }
}
