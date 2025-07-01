int n = int.Parse(Console.ReadLine());
string colour = Console.ReadLine();

int count = 0;
for(int i=0;i<colour.Length;i++)
{
    for(int j=i+1;j<colour.Length;j++)
    {
        if (colour[i] != colour[j])
            break;
        else
        {
            count++;
            break;
        }
    }
}
Console.WriteLine(count);
