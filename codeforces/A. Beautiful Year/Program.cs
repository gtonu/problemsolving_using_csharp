int year = int.Parse(Console.ReadLine());
bool flag = true;

while(flag==true)
{
    //int n = year;
    year++;
    int r1 = year % 10;
    int r2 = (year / 10) % 10;
    int r3 = (year / 100) % 10;
    int r4 = (year / 1000) % 10;

    if ((r1 != r2 && r1 != r3 && r1 != r4) && (r2 != r3 && r2 != r4) && (r3 != r4))
        break;
    
}
Console.WriteLine(year);
