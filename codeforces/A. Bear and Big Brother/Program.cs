string[] weights = Console.ReadLine().Split(' ');
int a = int.Parse(weights[0]);
int b = int.Parse(weights[1]);
int year = 1;
while(a<=b)
{
    a *= 3;
    b *= 2;
    if (a <= b)
        year++;
}

Console.WriteLine(year);
