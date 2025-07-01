int t = int.Parse(Console.ReadLine());

while(t>0)
{
    string word = Console.ReadLine();

    if (word.Length > 10)
    {
        Console.WriteLine($"{word[0]}{word.Length-2}{word[word.Length - 1]}");
    }
    else
        Console.WriteLine(word);

     t--;
}
