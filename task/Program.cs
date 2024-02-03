
const int N = 20; // размерность нашей матрицы(количество строк и столбцов)

int[,] serialMulres = new int[N,N]; // конечный результат матрицы

const int Thread = 10; // количество потоков

int[,] RandomGenerator(int size,int size1) // создание рандомного массива
{
    Random rnd = new();
    int[,] res = new int[size,size1];
    for(int i = 0;i < res.GetLength(0);i++)
    {
        for(int j = 0;j < res.GetLength(1);j++)
        {
            res[i,j] = rnd.Next(1,101);
        }
    }
    return res;
}


void PrintFunction(int[,] matrix) // вывод массива
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


void equal_matrix(int[,] first_matrix,int[,] second_matrix,int start,int end)
{
    for(int i = start;i < end;i++)
    {

        for(int k = 0;k < first_matrix.GetLength(1);k++) // столбец
        {

            for(int j = 0;j < first_matrix.GetLength(0);j++)  // строка
            {
                serialMulres[i,k] = first_matrix[i,k] * second_matrix[j,k]; // подсчет конечного результата,serialMulres[i,k] = тоесть с начальной позиции потока(i) начинаем записывать элементы в столбец(k),которые равны смежному произведению первой и второй матрицы
                //first_matrix[i,k] - первый параметр равен i - потому что,для первой матрицы,мы берем элементы из начальной позиции потока,тоесть из нулевого столбца(для первого потока,для второго будет уже другое значение)
                //а для второй матрицы мы берем смежные элементы первой матрицы,тоесть мы умножаем строки первой матрицы на столбцы второй по диагонали
            }
        }
    }
}


void ParallelMatrix (int[,] first_matrix,int[,] second_matrix) // принимает две матрицы
{
    int eachThread = N / Thread; // количество вычислительных элементов на один поток
    var thread_list = new List<Thread>(); // список который будет запускать поток
    for(int i = 0;i < Thread;i++) // цикл каждого потока,тоесть там 
    {
        int StartPos = i * eachThread; // стартовая позиция каждого потока
        int EndPos = (i + 1) * eachThread; // конечная позиция каждого потока (i + 1) - потому что начинаем с нуля
        if (i == Thread) // если поток последний,тоесть равен количеству
        {
            EndPos = N; // то тогда его конечная позиция будет равна остатку
        }
        thread_list.Add(new Thread(() => equal_matrix(first_matrix,second_matrix,StartPos,EndPos))); // здесь в лист мы добавляем по одному потоку и внутри потока вызываем анонимную функцию(лямбда функцию,которая как раз производит вычисления),передаем туда параметры(элементы первого массива и второго,а так же начальную и конечную позицию,после которой поток остановится и начнет выполнятся следующий)
        thread_list[i].Start(); // запускаем поток,сразу после вычисления
    }
    for(int i = 0;i < Thread;i++)
    {
        thread_list[i].Join(); // присоединение потоков к основному,чтобы они не продолжали свою работу
    }
}


int[,] first_matrix = RandomGenerator(N,N); //  заполнение первой матрицы случайными элементами

int[,] second_matrix = RandomGenerator(N,N); // завполнение второй матрицы случайными элементами

PrintFunction(first_matrix); // вывод первой матрицы

Console.WriteLine();

PrintFunction(second_matrix); // вывод второй матрицы

Console.WriteLine();

ParallelMatrix(first_matrix,second_matrix); // двумерный массив который будет хранить многопоточное умножение матриц размером [N12,N12],

PrintFunction(serialMulres);












































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

