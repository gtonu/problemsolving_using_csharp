string team = Console.ReadLine();

int count = 1;
bool flag = false;
for(int i=1;i<team.Length;i++)
{
    if (team[i] == team[i - 1])
    {
        count++;
        if (count >= 7)
            flag = true;
    }
    else
        count = 1;
}
if (flag)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");