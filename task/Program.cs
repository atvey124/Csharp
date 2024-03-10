Console.WriteLine("В данной игре тебе предстоит не умереть на минном поле,если наступаешь на бомбу 'X' - проигрываешь,победа засчитывается тогда когда открыл все поле");
Console.WriteLine();
Console.Write("Выберите сложность(сложная,нормальная,легкая,экстремальная,невозможная): ");
string complexity = Console.ReadLine()!;
int difficult = 0;
int size = 20;

switch(complexity.Length)
{
    case 11:
        difficult = 17;
        break;
    case 7:
        difficult = 7;
        break;
    case 13:
        difficult = 11;
        break;
    case 6:
        difficult = 3;
        break;
    case 10:
        difficult = 5;
        break;
}


char[,] GenerateFunction(int size,int difficult)
{
    Random rnd1 = new();
    char[,] RandomField = new char[size,size];
    for(int i = 0; i < RandomField.GetLength(0);i++)
    {
        int index_bomb = 0;
        while(index_bomb < difficult)
        {
            int random_position = rnd1.Next(0,size);
            for(int j = 0;j < RandomField.GetLength(1);j++)
            {
                if(random_position == j)
                {
                    RandomField[i,j] = 'X';
                    index_bomb++;
                }
            }
        }
        for(int k = 0;k < RandomField.GetLength(1);k++)
        {
            if(RandomField[i,k] != 'X')
                RandomField[i,k] = 'o';
        }
    }
    
    return RandomField;
}

string[] All_numbers = new string[20]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T"};

void PrintFunction(char[,] PlayField,string[] All_numbers)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("   " + string.Join("  ",All_numbers));
    Console.ResetColor();
    for(int i = 0;i < PlayField.GetLength(0);i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(All_numbers[i] + "  ");
        Console.ResetColor();
        for(int j = 0;j < PlayField.GetLength(1);j++)
        {
            if(PlayField[i,j] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(PlayField[i,j] + "  ");
                Console.ResetColor();
            }
            else if(PlayField[i,j] == 'o')
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(PlayField[i,j] + "  ");
                Console.ResetColor();
            }
            else if(PlayField[i,j] == 'v')
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(PlayField[i,j] + "  ");
                Console.ResetColor();
            }
        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(All_numbers[i] + "  ");
        Console.ResetColor();
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("   " + string.Join("  ",All_numbers));
    Console.ResetColor();
}


char[,] VoidFieldFunction(int size)
{
    char[,] VoidFieldF = new char[size,size];
    for(int i = 0;i < VoidFieldF.GetLength(0);i++)
    {
        for(int j = 0;j < VoidFieldF.GetLength(1);j++)
        {
            VoidFieldF[i,j] = 'v'; 
        }
            
    }
        
    return VoidFieldF;
}


char[,] VoidField = VoidFieldFunction(size);



void SapperFunction(char[,] PlayField,string[] All_numbers,char[,] VoidField)
{

    while(VoidField != PlayField)
    {
        PrintFunction(VoidField,All_numbers);
        Console.WriteLine();
        Console.Write("Выберите куда хотите походить по столбцам: ");
        string InputRow = Console.ReadLine()!.ToUpper();
        Console.Write("Выберите куда хотите походить по строкам: ");
        string InputStr = Console.ReadLine()!.ToUpper();
        int IndexRow = 0;
        int IndexStr = 0;
        int checkLetterRow = 0;
        int checkLetterStr = 0;
        for(int i = 0;i < All_numbers.Length;i++)
        {
            if(All_numbers[i] == InputRow){
                IndexRow = i;
            }
                
            else if(All_numbers[i] == InputStr){
                IndexStr = i;
            }
            
        }
        
        for(int k = 0;k < All_numbers.Length;k++)
        {
            if(All_numbers[k] == InputRow)
                checkLetterRow = 1;
     
        }
        for(int g = 0;g < All_numbers.Length;g++)
        {
            if(All_numbers[g] == InputStr)
                checkLetterStr = 1;
        }
        if(checkLetterRow != 1 || checkLetterStr != 1)
        {
            Console.WriteLine("Ты вышел за пределы поля");
            continue;
        }
           
        Console.WriteLine(IndexStr);
        Console.WriteLine(IndexRow);
        if(PlayField[IndexStr,IndexRow] == 'X')
        {
            Console.Write("          ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Т    Ы    П    Р    О    И    Г    Р    А    Л");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            PrintFunction(PlayField,All_numbers);
            return;
        }
        else
        {
            
            if(IndexStr + 1 == PlayField.GetLength(0))
            {
                for(int i = IndexStr - 2;i < IndexStr + 1;i++)
                {
                    if(IndexRow == 0)
                    {
                        for(int j = IndexRow;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow == 1)
                    {
                        for(int j = IndexRow - 1;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 1 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 1;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 2 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                }

            }
            else if(IndexStr + 2 == PlayField.GetLength(0))
            {
                for(int i = IndexStr - 2;i < IndexStr + 2;i++)
                {
                    if(IndexRow == 0)
                    {
                        for(int j = IndexRow;j < IndexRow + 1;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow == 1)
                    {
                        for(int j = IndexRow - 1;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 1 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 1;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 2 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    

                }

            }
            else if(IndexStr == 0)
            {
                for(int i = IndexStr;i < IndexStr + 2;i++)
                {
                    if(IndexRow == 0)
                    {
                        for(int j = IndexRow;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow == 1)
                    {
                        for(int j = IndexRow - 1;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 1 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 1;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 2 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                }
            }
            else if(IndexStr == 1)
            {
                for(int i = IndexStr - 1;i < IndexStr + 2;i++)
                {
                    if(IndexRow == 0)
                    {
                        for(int j = IndexRow;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow == 1)
                    {
                        for(int j = IndexRow - 1;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 1 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 1;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 2 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                }
            }
            else if(IndexStr == 2)
            {
                for(int i = IndexStr - 2;i < IndexStr + 2;i++)
                {
                    if(IndexRow == 0)
                    {
                        for(int j = IndexRow;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow == 1)
                    {
                        for(int j = IndexRow - 1;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 1 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 1;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 2 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                }
            }
            else
            {
                for(int i = IndexStr - 2;i < IndexStr + 2;i++)
                {
                    if(IndexRow == 0)
                    {
                        for(int j = IndexRow;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow == 1)
                    {
                        for(int j = IndexRow - 1;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 1 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 1;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else if(IndexRow  + 2 == PlayField.GetLength(1))
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                    else
                    {
                        for(int j = IndexRow - 2;j < IndexRow + 2;j++)
                            VoidField[i,j] = PlayField[i,j];
                    }
                }
            }
            


        }

    }
    Console.Write("          ");
    Console.BackgroundColor = ConsoleColor.Green;
    Console.Write("Т    Ы    В    Ы    И    Г    Р    А    Л");
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();
    PrintFunction(PlayField,All_numbers);
    return;

}









char[,] PlayField = GenerateFunction(size,difficult);

char[,] CopyPlayField = PlayField;

SapperFunction(PlayField,All_numbers,VoidField);



































































































