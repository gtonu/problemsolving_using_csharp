using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());
int[,] array = new int[n, 3];

for(int i=0;i<n;i++)
{
    string[] values = Console.ReadLine().Split(' ');
    for(int j=0;j<3;j++)
    {
        array[i, j] = int.Parse(values[j]);
    }
}

int totalX = 0,totalY=0,totalZ=0;
for(int i=0;i<3;i++)
{
    for(int j=0;j<n;j++)
    {
        if(i==0)
        {
            totalX += array[j, i];
        }
        else if(i==1)
        {
            totalY += array[j, i];
        }
        else
        {
            totalZ += array[j, i];
        }
    }
    
}
if (totalX!=0 || totalY!=0 || totalZ!=0)
{
    Console.WriteLine("NO");
}
else
    Console.WriteLine("YES");
