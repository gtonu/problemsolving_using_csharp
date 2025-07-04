int t = int.Parse(Console.ReadLine());
int rooms = 0;
while(t>0)
{
    string[] values = Console.ReadLine().Split(' ');
    int p = int.Parse(values[0]);
    int q = int.Parse(values[1]);
    if ((q - p) >= 2)
        rooms++;

    t--;
}
Console.WriteLine(rooms);