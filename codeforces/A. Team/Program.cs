int n = int.Parse(Console.ReadLine());
int ans = 0;
while (n>0)
{
    string[] values = Console.ReadLine().Split(' ');
    int c = 0;
    
    for(int i=0;i<values.Length;i++)
    {
        if (values[i] == "1")
            c++;
    }
    if (c >= 2) ans++;
    n--;
}
Console.WriteLine(ans);
