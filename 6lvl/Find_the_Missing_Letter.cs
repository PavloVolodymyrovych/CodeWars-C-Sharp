// See https://aka.ms/new-console-template for more information

Console.WriteLine("Final: " + FindMissingLetterFinal(new[] { 'A', 'B', 'C', 'D', 'F' }));
Console.WriteLine("Final: " + FindMissingLetterFinal(new[] { 'a', 'b', 'c', 'd', 'f' }));

static char FindMissingLetterFinal(char[] array)
{
    string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string alphabetLower = "abcdefghijklmnopqrstuvwxyz";

    int firstLatterUpper = alphabetUpper.IndexOfAny(array);
    int firstLatterLower = alphabetLower.IndexOfAny(array);

    if (firstLatterUpper != -1 && array[0] == alphabetUpper[firstLatterUpper])
    {
        for (int i = firstLatterUpper, x = 0; i < alphabetUpper[i]; i++, x++)
        {
            if (array[x] != alphabetUpper[i])
            {
                return alphabetUpper[i];
            }
        }
    }
    if(firstLatterLower != -1 && array[0] == alphabetLower[firstLatterLower])
    {
        for (int i = firstLatterLower, x = 0; i < alphabetLower[i]; i++, x++)
        {
            if (array[x] != alphabetLower[i])
            {
                return alphabetLower[i];
            }
        }
    }
    return ' ';
}