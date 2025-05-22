
int t = int.Parse(Console.ReadLine());
while(t>0)
{
    decimal n = decimal.Parse(Console.ReadLine());
    Console.WriteLine(Math.Floor((n * n) / 4) + 1);


    t--;
}