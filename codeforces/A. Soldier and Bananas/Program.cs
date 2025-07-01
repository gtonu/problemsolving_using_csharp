string[] values = Console.ReadLine().Split(' ');

int k = int.Parse(values[0]);
int n = int.Parse(values[1]);
int w = int.Parse(values[2]);

int total = 0;
for(int i=1;i<=w;i++)
{
    total += (k * i);
}
if (total > n)
    Console.WriteLine(total - n);
else
    Console.WriteLine("0");
