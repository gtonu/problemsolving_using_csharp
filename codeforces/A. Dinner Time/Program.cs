int t = int.Parse(Console.ReadLine());

while(t > 0)
{
    string[] values = Console.ReadLine().Split(' ');

    int n = int.Parse(values[0]);
    int m = int.Parse(values[1]);
    int p = int.Parse(values[2]);
    int q = int.Parse(values[3]);

    if (n % p == 0 && (q * n) / p != m)
        Console.WriteLine("NO");
    else
        Console.WriteLine("YES");






        t--;
}
