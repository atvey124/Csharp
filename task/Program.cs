int n_fact(int fact)
{
    
    if (fact <= 1)
    {
        return 1;
    }
    int size = n_fact(fact - 1);
    size = fact * size;
    int i = fact;
    Console.Write($"fact: {size} ");
    Console.Write($"Раскручивание рекурсии: {i}");
    Console.WriteLine();
    return size;
    

}
Console.Write("Введи факториал: ");
int fact = int.Parse(Console.ReadLine()!);
Console.WriteLine(n_fact(fact));
// отладчик - это программа которая позволяет запустить код в особом режиме(так и называется 'режим отладки')
// отладчик можно вызвать нажав кнопку 'run and debug'
//f11 - шаг с заходом,тоесть если на пути отладчика встретится функция он зайдет в нее
//f10 - шаг с обходом,если функция встретится он не зайдет в нее














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

