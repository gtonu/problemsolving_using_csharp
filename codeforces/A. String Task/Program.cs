using System.Text;

string word = Console.ReadLine();
StringBuilder newWord = new StringBuilder();

newWord.Append(word);
int count = 0;
Dictionary<char, int> position = new Dictionary<char,int>();

for(int i=0;i<newWord.Length;i++)
{
    if (newWord[i] == 'a' || newWord[i] == 'e' || newWord[i] == 'i' || newWord[i] == 'o' || newWord[i] == 'u')
    {
        position.Add(newWord[i], i);
        
    }
    else if(newWord[i] == 'A' || newWord[i] == 'E' || newWord[i] == 'I' || newWord[i] == 'O' || newWord[i] == 'U')
    {
        position.Add(newWord[i], i);

    }
    
    
}
foreach(var x in position)
{
    if (count > 0)
    {
        newWord.Remove(x.Value - 1, 1);
    }
    else
    {
        newWord.Remove(x.Value, 1);
        count++;
    }
}
//for (int i=0;i<newWord.Length;i+=2)
//{
//    newWord.Insert(i, '.');
//}
Console.WriteLine(newWord);
