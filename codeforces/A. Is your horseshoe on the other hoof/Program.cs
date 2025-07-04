string[] values = Console.ReadLine().Split(' ');
int count = 0;
string c = "a";
for(int i=0;i<values.Length-1;i++)
{
    if (c == values[i])
        continue;
    for(int j=i+1;j<values.Length;j++)
    {
        if (values[i] == values[j])
            count++;
    }
    c = values[i];
}
Console.WriteLine(count);