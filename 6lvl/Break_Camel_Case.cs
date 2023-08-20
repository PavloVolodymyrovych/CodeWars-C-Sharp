/*Complete the solution so that the function will break up camel casing, using a space between words.*/

Console.WriteLine(BreakCamelCase("camelCasing"));

static string BreakCamelCase(string str)
{
    // complete the function
    string value = "";
    foreach (char c in str)
    {
        if (char.IsUpper(c))
        {
            value += (" " + c); 
        }
        else
        {
            value += c;
        }
    }
    return value;
}