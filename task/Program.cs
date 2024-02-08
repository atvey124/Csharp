﻿Console.WriteLine("Введите размерность матрицы: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите от какого диапазона будут генерироваться случайные числа: ");

int from = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите до какого диапазона будут генерироваться случайные числа: ");

int to = int.Parse(Console.ReadLine()!);

int[,] RandomGenerator(int size,int from,int to)
{
    Random rnd = new();
    int[,] res = new int[size,size];
    for(int i = 0;i < res.GetLength(0);i++)
    {
        for(int j = 0;j < res.GetLength(1);j++)
        {
            res[i,j] = rnd.Next(from,to + 1);
        }

    }
    return res;
}

void PrintFunction(int[,] arr)
{
    for(int i = 0;i < arr.GetLength(0);i++)
    {
        for(int j = 0;j < arr.GetLength(1);j++)
            Console.Write(arr[i,j] + " ");
         Console.WriteLine();
    }
   
}

bool BasicTest(int[,] arr)
{
    for(int i = 0;i < arr.GetLength(0);i++)
    {
        for(int j = 0;j < arr.GetLength(1) - 1;j++)
        {
            if( arr[i,j] > arr[i,j + 1])
                return false;
        }
        
    }
    return true;
}

void BelowZero(int[,] arr)
{
    int less = 0;
    int more = 0;
    for(int i = 0;i < arr.GetLength(0);i++)
    {
        for(int j = 0;j < arr.GetLength(1);j++)
        {
            if(arr[i,j] >= 0)
            {
                more++;
            }
            else if ( arr[i,j] < 0)
            {
                less++;
            }  
        }
    }
    Console.WriteLine($"Количество элементов больше нуля(для простаты эксперимента ноль взят за положительное число): {more} ");
    Console.WriteLine($"Количество элементов меньшу нуля: {less}");
    return;

}


bool multiply_it()
{
    try
    {
        Console.Write("Хотите получить квадрат отсортированной матрицы?(да/все остальные варианты преравнены к false): ");
        string answer = Console.ReadLine()!;
        if(answer == "да")
        {
            return true;
        }
        else
        {
            return false;
        }

            
    }
    catch
    {
        Console.WriteLine("выберите (да/нет)");
        return false;
    }
    
    
}

int[,] square(int[,] arr,bool multiply_it)
{

    if (multiply_it == true)
    {
        for(int i = 0;i < arr.GetLength(0);i++)
        {
            for(int j = 0;j < arr.GetLength(1);j++)
            {
                arr[i,j] = arr[i,j] * arr[i,j];
            }
        }
        return arr;
    }
    else if (multiply_it == false)
    {
        return arr;
    }
    return arr;
        
}


int[,] CountingSort(int[,] arr,int size)
{

    int[,] sort_matrix = new int[size,size];


    for(int k = 0;k < sort_matrix.GetLength(0);k++ )
    {
        int min = arr[k,0];
        int max = arr[k,0];
        for(int i = 0;i < arr.GetLength(1);i++)
        {
            if ( min > arr[k,i])
            {
                min = arr[k,i];
            }
        }

        for(int i = 0;i < arr.GetLength(1);i++)
        {
            if ( max < arr[k,i])
            {
                max = arr[k,i];
            }
        }
        int offset = -min;
        int[] help_arr = new int[max + offset + 1];
        for(int i = 0;i < arr.GetLength(1);i++)
        {
            help_arr[arr[k,i] + offset]++;
        }

        int index = 0;
        for(int i = 0;i < help_arr.Length;i++)
        {
            for(int j = 0;j < help_arr[i];j++)
            {
                sort_matrix[k,index] = i - offset;
                index++;
            }
        }


    }
    return sort_matrix;
}


int[,] matrix = RandomGenerator(size,from,to);

Console.WriteLine("Исходный массив: ");

PrintFunction(matrix);

Console.WriteLine(BasicTest(matrix));

int[,] counting_matrix = CountingSort(matrix,size);

Console.WriteLine("Отсорт.массив: ");

PrintFunction(counting_matrix);

Console.WriteLine(BasicTest(counting_matrix));

BelowZero(counting_matrix);

bool multi = multiply_it();

square(counting_matrix,multi);

Console.WriteLine("квадрат отсортированной матрицы: ");

PrintFunction(counting_matrix);










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
*/
