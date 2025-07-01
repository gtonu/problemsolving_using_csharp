string a = Console.ReadLine();
string b = Console.ReadLine();

int j = b.Length - 1;
bool flag = true;
if (a.Length == b.Length)
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] != b[j])
        {
            flag = false;
            break;
        }
        else
            j--;
    }
}
else
    flag = false;

if (flag)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");