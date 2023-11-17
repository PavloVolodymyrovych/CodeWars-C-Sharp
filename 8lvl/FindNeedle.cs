static string FindNeedle(object[] haystack)
{
    for (int i = 0; i <= haystack.Length-1; i++)
    {
        if (haystack[i] == "needle")
        {
            return $"found the needle at position {i}";
        }
    }
    return "";
}
Console.Write("1) "+FindNeedle(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false }));
