static int[] SquareOrSquareRoot(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (Math.Sqrt(array[i]) % 1 == 0)
        {
            array[i] = (int) Math.Sqrt(array[i]);
        }
        else
        {
            array[i] = (int)Math.Pow(array[i], 2);
        }
        Console.WriteLine($"Index {i}: {array[i]}");
    }
    return array;
}
Console.Write("Result test 1: " + SquareOrSquareRoot(new int[] { 4, 3, 9, 7, 2, 1 }));
Console.Write("\nResult test 2: " + SquareOrSquareRoot(new int[] { 2, 9, 3, 49, 4, 1 }));
Console.Write("\nResult test 3: " + SquareOrSquareRoot(new int[] { 10, 10201, 25, 25, 1, 1 }));
