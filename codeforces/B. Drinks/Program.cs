int n = int.Parse(Console.ReadLine());
string[] values = Console.ReadLine().Split(' ');
int sum = 0;
for(int i=0;i<values.Length;i++)
{
    sum += int.Parse(values[i]);
}


decimal ans = (decimal)sum / (decimal)n;
Console.WriteLine(ans.ToString("F12"));
