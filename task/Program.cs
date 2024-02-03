// // функция которая найдет нужный элемент который попросил пользователь в двумерном массиве,так же можно указать сколько раз это нужно повторить,ответ занесется в одномерный массив

Random str111 = new();
Random str1111 = new();
int str = str111.Next(1,11); // рандомное количество строк
int str1 = str1111.Next(1,11); // рандомное количество столбцов


int[,] random1_matrix(int str,int str1)
{
    Random rnd = new();
    int[,] matrix = new int[str,str1 + 1]; // создание двумерного массива и передача туда параметров,что введет пользователь(количество строк и столбцов)
    for(int i = 0;i < matrix.GetLength(0);i++) // цикл который отвечает за строки
    {
        for(int j = 0;j < matrix.GetLength(1);j++) // цикл который отвечает за столбцы
        {
            matrix[i,j] = rnd.Next(1,100);
        }
        
    }
    
    return matrix;
}

int[] IsElement(int[,] matrix) // функция которая найдет нужный элемент который попросил пользователь в двумерном массиве,так же можно указать сколько раз это нужно повторить,ответ занесется в одномерный массив
{
    Console.Write("Введите сколько элементов нужно найти: ");
    int repeat = int.Parse(Console.ReadLine()!);
    int[] repeat_arr = new int[repeat]; // длина массив такая которую ввел пользователь
    for(int i = 0;i < repeat_arr.Length;i++)
    {

    

        Console.Write("Введите на какой строке вы хотите найти элемент: ");

        int str_input = int.Parse(Console.ReadLine()!);

        Console.Write("Введите индекс какого элемента вы хотите найти: ");

        int column_input = int.Parse(Console.ReadLine()!);
        try // если такой индекс есть то он заносится в массив
        {
            Console.WriteLine($"Элемент {matrix[str_input,column_input]}");
            repeat_arr[i] = matrix[str_input,column_input];
            
        } 
        catch // если нет
        {
            Console.WriteLine($"Индекс за пределом массива {str_input} {column_input}");
            Console.WriteLine($"Количество строк: {str + 1}, количество столбцов: {str + 1}");
            i--;
        }
        
    }
    return repeat_arr;

}
    

    
void print_matrix1(int[,] matrix) // функция вывода двумерного массива
{
    for(int i = 0;i < matrix.GetLength(0);i++)
    {
        for(int j = 0;j < matrix.GetLength(1);j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
 
int[,] matrix = random1_matrix(str,str1);

print_matrix1(matrix);

int[] IsElement1 = IsElement(matrix); // 
Console.WriteLine($"Получившейся массив: [{string.Join(", ",IsElement1)}]");



















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

