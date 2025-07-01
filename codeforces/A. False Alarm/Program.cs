
int t = int.Parse(Console.ReadLine());

while(t>0)
{
    string[] values = Console.ReadLine().Split(' ');
    int n = int.Parse(values[0]);
    int x = int.Parse(values[1]);

    int[] doors = new int[n];
    string[] strings = Console.ReadLine().Split(' ');

    for(int i=0;i<strings.Length;i++)
    {
        doors[i] = int.Parse(strings[i]);
    }
    int max = -1;
    int min = 11;

    for(int i=0;i<doors.Length;i++)
    {
        if (doors[i]==1)
        {
            if (i < min) min = i;
            else if (i > max) max = i;
        }
    }

    if (((max - min) + 1) <= x)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");




        t--;
}
