int t = int.Parse(Console.ReadLine());
char c = 'a';
int count = 0;
while(t>0)
{
    string s = Console.ReadLine();
    if (c == '0' || c == '1')
    {
        if (s[0] == c)
        {
            count++;
            c = s[1];
        }
        else
        {
            c = s[1];
        }
    }
    else
        c = s[1];
        t--;
}
Console.WriteLine(count+1);
