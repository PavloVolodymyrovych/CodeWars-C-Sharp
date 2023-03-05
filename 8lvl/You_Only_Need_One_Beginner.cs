using System;
using System.Linq;

/*  https://www.codewars.com/kata/57cc975ed542d3148f00015b/train/csharp */
namespace You_Only_Need_One_Beginner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Test one: {Check(new object[] { 't', 'e', 's', 't' }, 'e')}");
            Console.WriteLine($"Test two: {Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45)}");
            Console.WriteLine($"Test three: {Check(new object[] { "what", "a", "great", "kata" }, "kat")}");
        }
        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);
        }
    }
}
