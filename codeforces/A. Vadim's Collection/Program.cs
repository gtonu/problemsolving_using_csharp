int t = int.Parse(Console.ReadLine());

while(t>0)
{
    string number = Console.ReadLine();
    int[] counter = new int[number.Length];
    char[] chars = number.ToCharArray();

    for(int i=0; i<number.Length; i++)
    {
        int v = int.Parse(number[i].ToString());
        counter[v]++;
        
    }
    //for (int i = 0; i < counter.Length; i++)
    //{
    //    Console.WriteLine(counter[i]);
    //}
    for (int i = 1; i < number.Length; i++)
    {
        
        
            for (int j = (10 - (i + 1)); j >= 0; j--)
            {
                if (counter[j] > 0)
                {
                    if()

                }
            }
        
    }

    for(int i=0; i<chars.Length; i++)
    {
        Console.Write(chars[i]);
    }
    Console.WriteLine();


    t--;
}