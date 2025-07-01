long n = long.Parse(Console.ReadLine());
int count =0;
while(n>0)
{
    int r = (int) (n % 10);
    n /= 10;
    if (r == 4 || r == 7)
        count++;
}
if (count == 4 || count == 7)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
//Console.WriteLine(count);