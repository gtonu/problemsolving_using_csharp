using System.Globalization;

int t = int.Parse(Console.ReadLine());

while(t>0)
{
    int year = int.Parse(Console.ReadLine());
    int sqrtYear = (int)Math.Sqrt(year);

    if((sqrtYear*sqrtYear)==year)
    {
        if ((sqrtYear  % 2 ) != 0)
        {
            if (sqrtYear == 1)
                Console.WriteLine("0 1");
            else if (sqrtYear < 10)
                Console.WriteLine($"2 {sqrtYear - 2}");
            else
                Console.WriteLine($"10 {sqrtYear - 10}");
        }
        else if ((sqrtYear % 2) == 0)
        {
            Console.WriteLine($"{sqrtYear / 2} {sqrtYear / 2}");
        }
        
    }
    
    else
    {
        Console.WriteLine("-1");
    }


        t--;
}
