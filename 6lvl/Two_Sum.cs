TwoSum(new int[] { 1, 2, 3 }, 4);
TwoSum(new int []{ 1234, 5678, 9012 }, 14690);
TwoSum(new int[] { 2, 2, 3 }, 4);

/*The solution proposed by GPT-3.5 is being tested*/
static int[] TwoSum(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[i] + numbers[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }
    return new int[0]; // Якщо пара чисел не знайдена
}

/*My solution, but it does not pass the tests on the "CodeWars" site, I get all the same result values.
static int[] TwoSum(int[] numbers, int target)
{
    int index1 = 0;
    int index2 = 0;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = 1; j <= numbers.Length -1; j++)
        {
            if (numbers[i] + numbers[j] == target)
            {
                index1 = i;
                index2 = j;
                return new int[] { numbers[index1], numbers[index2] };
            }
        }
        if (numbers[index1] + numbers[index2] == target)
        {
            break;
        }
    }
    Console.WriteLine($"1-Index: {numbers[index1]}");
    Console.WriteLine($"2-Index: {numbers[index2]}");
    Console.WriteLine($"Sum of index values: { numbers[index1] + numbers[index2]}\n");
    return new int[0];
}
*/