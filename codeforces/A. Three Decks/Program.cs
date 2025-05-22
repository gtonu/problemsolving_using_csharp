int t = int.Parse(Console.ReadLine());

while(t>0)
{
    string[] values = Console.ReadLine().Split(' ');
    int a = int.Parse(values[0]);
    int b = int.Parse(values[1]);
    int c = int.Parse(values[2]);

    if((a+b+c)%3 != 0)
    {
        Console.WriteLine("NO");
    }
    else
    {
        if ((a > (a + b + c) / 3) || (b > (a + b + c) / 3))
            Console.WriteLine("NO");
        else
            Console.WriteLine("YES");
    }


        t--;
}
