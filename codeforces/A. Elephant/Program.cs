int distance = int.Parse(Console.ReadLine());
int steps = 0;

while(distance>0)
{
    if(distance>=5)
    {
        distance -= 5;
        steps++;
    }
    else if(distance>=4)
    {
        distance -= 4;
        steps++;
    }
    else if(distance>=3)
    {
        distance -= 3;
        steps++;
    }
    else if(distance>=2)
    {
        distance -= 2;
        steps++;
    }
    else
    {
        distance -= 1;
        steps++;
    }
}

Console.WriteLine(steps);
