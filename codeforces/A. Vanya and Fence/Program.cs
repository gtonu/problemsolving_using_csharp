string[] values = Console.ReadLine().Split(' ');
int n = int.Parse(values[0]);
int h = int.Parse(values[1]);

int[] heights = new int[n];
string[] height = Console.ReadLine().Split(' ');
int count = 0;
for (int i = 0; i < n; i++)
{
    heights[i] = int.Parse(height[i]);
    if (heights[i] > h)
        count += 2;
    else
        count++;
}
Console.WriteLine(count);

