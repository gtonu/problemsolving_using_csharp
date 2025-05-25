int t = int.Parse(Console.ReadLine());

while(t>0)
{
    int n = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();

    int oCounter = 0;
    int ones = 0;

    for(int i=0; i<s.Length; i++)
    {
        if (s[i] == '1')
            oCounter++;
    }
    
    for(int i=0;  i<s.Length; i++)
    {
        if (s[i] == '1')
            ones += oCounter - 1;
        else
            ones += oCounter + 1;
    }
    Console.WriteLine(ones);



    t--;
}
