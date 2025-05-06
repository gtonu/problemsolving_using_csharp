
int middleXcoOrdinate = 3;
int middleYcoOrdinate = 3;

int xCoOrdinate = 0;
int yCoOrdinate = 0;

for(int i=1; i<=5; i++)
{
    string[] elements = Console.ReadLine().Split(' ');
    for (int j=0; j<elements.Length; j++)
    {
        if (elements[j] == "1")
        {
            xCoOrdinate = i;
            yCoOrdinate = j + 1;
        }
    }
}

int xMoves = middleXcoOrdinate - xCoOrdinate;
int yMoves = middleYcoOrdinate - yCoOrdinate;

Console.Write(Math.Abs(xMoves) + Math.Abs(yMoves));
