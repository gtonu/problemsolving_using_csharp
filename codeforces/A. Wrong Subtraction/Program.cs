string[] values = Console.ReadLine().Split(' ');
int n = int.Parse(values[0]);
int k = int.Parse(values[1]);

while(k>0)
{
    int r = n % 10;
    if (r == 0)
        n /= 10;
    else
        n--;
    k--;
}
Console.WriteLine(n);
