using System;
using System.Linq;

namespace Grasshopper_Grade_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Test 1: {GetGrade(95, 90, 93)}");
            Console.WriteLine($"Test 2: {GetGrade(70, 70, 100)}");
            Console.WriteLine($"Test 3: {GetGrade(70, 71, 72)}");
            Console.WriteLine($"Test 4: {GetGrade(65, 66, 60)}");
            Console.WriteLine($"Test 5: {GetGrade(32, 15, 21)}");
        }
        public static char GetGrade(int s1, int s2, int s3)
        {
            char symbol = ' ';
            int[] array = new int[] {s1, s2, s3 };
            int maxNumber = array.Sum() / 3;
            if (maxNumber >= 0 && maxNumber < 60)
                symbol = 'F';
            else if (maxNumber >= 60 && maxNumber < 70)
                symbol = 'D';
            else if (maxNumber >= 70 && maxNumber < 80)
                symbol = 'C';
            else if (maxNumber >= 80 && maxNumber < 90)
                symbol = 'B';
            else if (maxNumber >= 90 && maxNumber <= 100)
                symbol = 'A';
            return symbol;
        }
    }
}
