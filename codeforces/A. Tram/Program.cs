int t = int.Parse(Console.ReadLine());
int capacity = -1;
int max = 0;
while(t>0)
{
    string[] values = Console.ReadLine().Split(' ');
    int a = int.Parse(values[0]);
    int b = int.Parse(values[1]);
    max -= a;
    max += b;

    if (max > capacity) capacity = max;
    t--;
}
Console.WriteLine(capacity);
