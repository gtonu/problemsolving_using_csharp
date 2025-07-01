using System.Text;

string word = Console.ReadLine();

int[] array = new int[26];
int count = 0;
for(int i=0;i<word.Length;i++)
{
    array[word[i] - 'a']++;
}
//Console.WriteLine(count);
for(int i=0;i<array.Length;i++)
{
    if (array[i] > 0)
        count++;
}
if (count % 2 == 0)
    Console.WriteLine("CHAT WITH HER!");
else
    Console.WriteLine("IGNORE HIM!");

