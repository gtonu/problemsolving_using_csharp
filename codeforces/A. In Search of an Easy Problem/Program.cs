int n = int.Parse(Console.ReadLine());

string[] values = Console.ReadLine().Split(' ');
int[] opinion = new int[n];
int count = 0;
for(int i =0; i<values.Length; i++)
{
    opinion[i] = int.Parse(values[i]);
    if (opinion[i] == 1) count++;
}
if (count > 0) Console.WriteLine("HARD");
else Console.WriteLine("EASY");
