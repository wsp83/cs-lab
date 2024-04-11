using System;

namespace z2
{
    internal class zadatak2
    {
        static void Main(string[] args)
        {
            int var1 = 0;
            long var2 = long.MaxValue;

            try
            {
                checked
                {
                    var1 = (int)var2;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("int var1 = " + var1);
        }
    }
}
