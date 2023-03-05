using System;

namespace Convert_a_Number_to_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"This numbers convert to string: {NumberToString(123)}");
            Console.WriteLine($"This numbers convert to string: {NumberToString(999)}");
            Console.WriteLine($"This numbers convert to string: {NumberToString(-100)}");
        }
        public static string NumberToString(int num)
        {
            return num.ToString();
        }
    }
}
