string[] values = Console.ReadLine().Split(' ');
long n = long.Parse(values[0]);
long k = long.Parse(values[1]);
if(n%2==0)
{
    if ((n / 2) >= k)
    {
        Console.WriteLine(2 * k - 1);
    }
    else
    {
        Console.WriteLine(2 * (k - (n / 2)));
    }
}
else
{
    if (((n+1) / 2) >= k)
    {
        Console.WriteLine(2 * k - 1);
    }
    else
    {
        Console.WriteLine(2 * (k - ((n+1) / 2)));
    }
}

