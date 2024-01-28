Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine()!);
Random rnd_num = new();
int[] arrr = new int[size];
for (int i = 0;i < size;i++)
{
    arrr[i] = rnd_num.Next(-30,100);
}


bool test (int[] arrr) // базовый тест,который будет выводить true - если массив отсортирован и false если нет
{
    for(int i = 0;i < arrr.Length;i++)
    {
        if ( arrr[i] > arrr[i + 1]) // чтобы понять отсортирован ли массив,достаточно сравнить первый элемент со вторым,если первый больше массив не отсортирован,далее сравниваем все элементы
            return false;
    }
    return true;
}


int[] bubble_function(int[] arrr)
{
    for (int i = 0;i < arrr.Length - 1;i++) // arrr.Length - 1,поскольку для перестановки первых двух элементов требуется одно действие,а не два,для перестановки трех элементов требуется два действия,для перестановки четырех - 4,тоесть один элемент двигать не приходится
    {
        for ( int j = 0;j < arrr.Length - 1 - i;j++) // -i сделано потому что когда мы переместили элемент на свою позицию,нам больше не обязательно смотреть на него(он уже стоит на своем месте)
        {
            int temp1 = arrr[j];
            if (arrr[j] > arrr[j + 1])
            {
                arrr[j] = arrr[j + 1];
                arrr[j + 1] = temp1;

            }
        }

    }
    return arrr;
}
Console.WriteLine($"начальный массив: {string.Join(",", arrr)}");
Console.WriteLine($"готовый массив: {string.Join(",", bubble_function(arrr))}");
Console.WriteLine(test(arrr));


























// простая задача на угадывание случайного числа
Random random = new();
Random random2 = new();
int random1 = random.Next(1,101);
int random3 = random2.Next(1,1001);
int attempt = 10;
int attempt1 = 10;
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

