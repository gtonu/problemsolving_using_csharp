string[] numbers = Console.ReadLine().Split(' ');
int n = int.Parse(numbers[0]);
int k = int.Parse(numbers[1]);

string[] values = Console.ReadLine().Split(' ');
int[] score = new int[n];
for(int i=0;i<n;i++)
{
    score[i] = int.Parse(values[i]);
}
int participants = 0;

for(int i=0;i<n;i++)
{
    if (score[i]!=0 && score[i] >= score[k - 1])
        participants++;
}

Console.WriteLine(participants);
