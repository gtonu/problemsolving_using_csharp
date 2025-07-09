using System.Collections.Immutable;

int n = int.Parse(Console.ReadLine());

string[] values = Console.ReadLine().Split(' ');
int[] coins = new int[n];
int total = 0;
for(int i=0;i<n;i++)
{
    coins[i] = int.Parse(values[i]);
    total += coins[i];
}
Array.Sort(coins);
Array.Reverse(coins);
//int preSum = 0;
////int postSum = 0;
//for(int i =0;i<=n/2;i++)
//{
//    preSum += coins[i];
//}

//if (preSum >= (total - preSum))
//    Console.WriteLine((n / 2) + 1);
//else
//    Console.WriteLine(n - ((n / 2) + 1));
//int ans = n;
int share = 0;
int ans = 0;
//if (coins[0] == coins[n - 1])
//    Console.WriteLine((n / 2) + 1);

    for (int i = 0; i<coins.Length; i++)
    {

    if (total < share)
        break;
    else
    {
        share += coins[i];
        total -= coins[i];
        ans++;
    }
    
    }
    Console.WriteLine(ans);

    