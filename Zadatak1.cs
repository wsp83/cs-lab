using System;
using System.Text;

namespace lab1
{
    internal class Zadatak1
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            var input1 = Console.ReadLine();

            Console.Write("Second number: ");
            var input2 = Console.ReadLine();


            Int32.TryParse(input1, out var intInput1);
            Int32.TryParse(input2, out var intInput2);

            var resultDecimal = (Decimal)intInput1 / intInput2;
            var resultInteger = intInput1 / intInput2;
            var resultDouble = (Double)intInput1 / intInput2;

            Console.WriteLine("Currency: " + resultDecimal.ToString("C"));
            Console.WriteLine("Integer: " + resultInteger);
            Console.WriteLine("Scientific: " + resultDouble.ToString("e"));
            Console.WriteLine("Fixed-point: " + resultDouble.ToString("F"));
            Console.WriteLine("General: " + resultDouble.ToString("G"));
            Console.WriteLine("Number: " + resultDouble.ToString());
            Console.WriteLine("Hexadecimal: " + ((int)resultDouble).ToString("X"));
        }
    }
}
