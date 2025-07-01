int t = int.Parse(Console.ReadLine());

while(t>0)
{
    string[] values = Console.ReadLine().Split(' ');
    int n = int.Parse(values[0]);
    int m = int.Parse(values[1]);
    int l = int.Parse(values[2]);
    int r = int.Parse(values[3]);

    if(m<=r)
    {
        Console.WriteLine($"0 {m}");
    }
    else
    {
        Console.WriteLine($"{r - m} {r}");
    }


        t--;
}
