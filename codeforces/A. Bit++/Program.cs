
int x = 0;
int n = int.Parse(Console.ReadLine());

for(int i=0; i<n; i++)
{
    string operation = Console.ReadLine();
    if (operation[1] == '+')
        x++;
    else
        x--;

}
Console.Write(x);
