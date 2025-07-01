using System.Text;

string word = Console.ReadLine();

StringBuilder newWord = new StringBuilder();
newWord.Append(word);

char first=Char.ToUpper(newWord[0]);
newWord.Remove(0, 1);
newWord.Insert(0, first);

Console.WriteLine(newWord);


