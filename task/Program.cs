int numz = int.Parse(Console.ReadLine()!); 
int[, ] matrix1 = new int[numz,numz]; // создание матрицы
for(int e1 = 0;e1 < numz;e1++) //цикл который будет выводить в терминал числа по вертикале
{
    for(int j = 0;j < numz;j++) // цикл который будет выводить числа по горизонтали
    {  
        matrix1[e1,j] = (e1 + 1) * (j + 1); // если нет,i = элементы матрицы по горизонтали и они просто перемнажаются,тоесть смежные элементы перемнажаются
        matrix1[j,e1] = (e1 + 1) * (j + 1); // j = элементы матрицы по вертикале и они просто перемнажаются
    }
 
}   
for(int iii = 0;iii < numz;iii++)
{
    for(int k = 0;k < numz;k++)
    {
        Console.Write(matrix1[iii,k]);  // цикл вывода в терминал значений матрицы 
        Console.Write(" ");
    }
    Console.WriteLine();
} // сложность данного алгоритма O((n ^ 2) / 2)












































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

