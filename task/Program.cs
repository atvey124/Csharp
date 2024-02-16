//задача на сортировку дробной матрицы по целому числу

Console.WriteLine("Введите диапазон от: ");

int from = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите диапазон до: ");

int to = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите размер матрицы: ");

int size = int.Parse(Console.ReadLine()!);

double[,] RandomGenerator(int from,int to,int size)
{
    
    Random random = new Random();
    double min = from;
    double max = to;
    double range = max - min;
    double[,] double_arr = new double[size,size];
    for (int i = 0; i < double_arr.GetLength(0); i++)
    {
        for(int j = 0;j < double_arr.GetLength(1);j++)
        {
            double sample = random.NextDouble();
            double scaled = (sample * range) + min;
            double_arr[i,j] = (float)scaled;

        }
        
    }
    return double_arr;
}

void PrintFunction(double[,] double_arr)
{
    for(int i = 0;i < double_arr.GetLength(0);i++)
    {
        Console.Write($"Строка {i + 1} " + "    ");
        for(int j = 0;j < double_arr.GetLength(1);j++)
        {
            if (double_arr[i,j] != 0)
                Console.Write(double_arr[i,j] + "    ");
        }
        Console.WriteLine();
        
    }
}

double[,] SortFunction(double[,] RandomArr,double from,double to,int size,int to1)
{
    
    double range3 = from;
    double range4 = from + 1.0;
    int[] size_index = new int[to1 - 1];
    int size_of_row = 0;
    for(int k = 0;k < to1 - 1;k++)
    {
        for(int i = 0;i < RandomArr.GetLength(1);i++)
        {
            for(int j = 0;j < RandomArr.GetLength(1);j++)
            {
                if (RandomArr[i,j] >= range3 && RandomArr[i,j] <= range4)
                    size_of_row++;

            }


        }
        range3 += 1.0;
        range4 += 1.0;
        size_index[k] = size_of_row;
        size_of_row = 0;
        
    }
    int max = size_index.Max();
    double[,] SortedArray = new double[to1 - 1,max];

    range3 = from;
    range4 = from + 1;
    int current_index = 0;
    for(int k = 0;k < to1 - 1;k++)
    {
        for(int i = 0;i < RandomArr.GetLength(1);i++)
        {
            for(int j = 0;j < RandomArr.GetLength(1);j++)
            {
                if (RandomArr[i,j] >= range3 && RandomArr[i,j] <= range4)
                {

                    SortedArray[k,current_index] = RandomArr[i,j];
                    

                    current_index++;
                }

            }


        }
        current_index = 0;
        range3 += 1.0;
        range4 += 1.0;
    }
    return SortedArray;
        
        
}


double[,] RandomArr = RandomGenerator(from,to,size);

PrintFunction(RandomArr);

double from2 = from;
double to2 = to;

double[,] SortArr = SortFunction(RandomArr,from2,to2,size,to);

Console.WriteLine();
PrintFunction(SortArr);


























/*
// простая задача на угадывание случайного числа
Random random = new();
Random random2 = new();
int random1 = random.Next(1,101);
int random3 = random2.Next(1,1001);
int attempt = 10;
int attempt1 = 15;
int win = 0;
int remaining_attempt = 1;
int remaining_attempt1 = 1;
while(attempt != 0)
{ 
    if (attempt > 4)
    {
        Console.Write($"У тебя осталось {attempt} попыток, ");
        Console.Write("Введи загаданное число от 1 до 100: ");
    } 
    else if ( attempt <= 4)
    {
        Console.Write($"У тебя осталось {attempt} попытки, ");
        Console.Write("Введи загаданное число от 1 до 100: ");

    }
    
    try
    {
        int num_people = int.Parse(Console.ReadLine()!);
        if (num_people <= 100)
        {

    
            if (random1 != num_people)
            {
                if ( random1 > num_people)
                {
                    Console.WriteLine("Загаданое число больше");
                    attempt--;
                    remaining_attempt++;
                }
                else if ( random1 < num_people)
                {
                    Console.WriteLine("Загаданное число меньше");
                    attempt--;
                    remaining_attempt++;
                }

            }
            else
            {
                Console.WriteLine($"Ты выиграл с {remaining_attempt} попытки ,загаданное число было {random1}!");
                win++;
                if (win == 1)
                {  
                    Console.WriteLine();
                    Console.WriteLine("РАЗ УЖ ТЫ ВЫИГРАЛ,ПОПРОБУЙ ЭТО!!!");
                    while ( attempt1 != 0)
                    { 
                        if (attempt1 > 4)
                        {
                            Console.Write($"У тебя осталось {attempt1} попыток, ");
                            Console.Write("Введи загаданное число от 1 до 1000: ");
                        }
                        else if (attempt1 <= 4)
                        {
                            Console.Write($"У тебя осталось { attempt1} попытки, ");
                            Console.Write("Введи загаданное число от 1 до 1000: ");
                        }
                        int num_people2 = int.Parse(Console.ReadLine()!);
                        if (num_people2 <= 1000)
                        {
                    
                              
                            if (random3 != num_people2)
                            {
                                if ( random3 > num_people2)
                                {
                                    Console.WriteLine("Загаданное число больше");
                                    attempt1--;
                                    remaining_attempt1++;
                                }
                                else if ( random3 < num_people2)
                                {
                                    Console.WriteLine("Загаданное число меньше");
                                    attempt1--;
                                    remaining_attempt1++;
                                }
                            }
                        else
                        {
                            Console.WriteLine($"Ты выиграл с {remaining_attempt1} попытки,загаданное число было {random3}! ");
                            break;
                        }
                        }      
                    else
                    {
                        Console.WriteLine("Ты ввел число больше чем диапазон угадывания ");
                    }
                
                    
                
                

                    }
                    Console.WriteLine($"Ты не смог угадать число от 1 до 1000, загаданное число было {random3}");
                    break;         

                }
            }
        }
        else
        {
            Console.WriteLine("Ты ввел число больше диапазона угадывания ");
        }
    }
    catch
    {
        Console.WriteLine("Вы ввели не тот тип данных(требуется 'int')");
    }
}











Random rnd = new();
Console.WriteLine("Введите диапазон от: ");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон до: ");
int to = int.Parse(Console.ReadLine()!);
int input_num = rnd.Next(from,to + 1);
Console.WriteLine(input_num);




int GuessFunction(int from,int to,int input_num)
{
    int attempt = 1;
    int[] input_num_arr = new int[to + 1];
    for(int i = 0;i < input_num_arr.Length;i++)
    {
        input_num_arr[i] = i;
        //Console.Write(input_num_arr[i] + " ");
    }
    Console.WriteLine();

    int start = from;
    int end = input_num_arr.Length - 1;
    while( start <= end)
    {
        int mid = (start + end) / 2;
        if (input_num_arr[mid] == input_num)
        {
            Console.WriteLine(input_num_arr[mid]);
            Console.WriteLine($"программа угадала число с {attempt} попытки");
            return mid;
        }
        else if(input_num_arr[mid] > input_num)
        {
            end = mid - 1;
            attempt++;
        }
        else if(input_num_arr[mid] < input_num)
        {
            start = mid + 1;
            attempt++;
        }
    }
    return 0;
}


GuessFunction(from,to,input_num);

*/
