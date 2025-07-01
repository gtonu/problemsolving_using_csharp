int t = int.Parse(Console.ReadLine());

while(t>0)
{
    string s = Console.ReadLine();
    string newS = "";
    newS += s[0];
    for(int i=0;i<s.Length;i++)
    {
        if (s[i]==' ')
        {
            newS += s[i + 1];
        }
    }
    Console.WriteLine(newS);


    t--;
}
