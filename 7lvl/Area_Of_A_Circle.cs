Console.WriteLine(CalculateAreaOfCircle(68.0)); //
static double CalculateAreaOfCircle(double radius)
{
    if (radius > 0)
    {
        return Math.PI * (radius * radius);
    }
    else
    {
        throw new ArgumentException("ArgumentException");
    }
}