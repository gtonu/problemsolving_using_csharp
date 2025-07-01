int n = int.Parse(Console.ReadLine());
string game = Console.ReadLine();
int a = 0, d = 0;
for(int i=0;i<game.Length;i++)
{
    if (game[i] == 'A')
        a++;
    else
        d++;
}
if (a > d)
    Console.WriteLine("Anton");
else if (a < d)
    Console.WriteLine("Danik");
else
    Console.WriteLine("Friendship");
