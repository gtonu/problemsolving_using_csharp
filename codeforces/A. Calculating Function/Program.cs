long n = long.Parse(Console.ReadLine());

if(n%2==0)
{
    long nEven = n / 2;
    long nOdd = n / 2;
    long sumEven = (nEven * (nEven + 1));
    long sumOdd = (nOdd * nOdd);
    Console.WriteLine(sumEven - sumOdd);
}
else
{
    long nOdd = (n + 1) / 2;
    long nEven = n - nOdd;
    long sumEven = (nEven * (nEven + 1));
    long sumOdd = (nOdd * nOdd);
    Console.WriteLine(sumEven - sumOdd);
}
