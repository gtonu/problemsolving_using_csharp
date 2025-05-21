
int t = int.Parse(Console.ReadLine());

while(t > 0)
{
    int n = int.Parse(Console.ReadLine());
    int[] array = new int[n];
    string[] values = Console.ReadLine().Split(' ');
    for(int i=0; i<values.Length; i++)
    {
        array[i] = int.Parse(values[i]);
    }

    int max = array.Max();
    int min = array.Min();

    if (max == min)
        Console.WriteLine("NO");
    else
    {
        Console.WriteLine("YES");
        for(int i=0; i<n; i++)
        {
            if (array[i] == max)
            {
                Console.Write("1");
                Console.Write(" ");
            }
            else
            {
                Console.Write("2");
                Console.Write(" ");
            }
           
        }
        Console.WriteLine();
    }
        


        t--;
}
