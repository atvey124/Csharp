Random random = new();
Random random2 = new();
int random1 = random.Next(1,101);
int random3 = random2.Next(1,1001);
int attempt = 10;
int attempt1 = 10;
int win = 0;
int remaining_attempt = 0;
int remaining_attempt1 = 0;
while(attempt != 0)
{   
    Console.Write($"У тебя осталось {attempt} попыток, ");
    Console.Write("Введите загаданное число: ");
    
    int num_people = int.Parse(Console.ReadLine()!);
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
                Console.Write($"У тебя осталось {attempt1} попыток, ");
                Console.Write("Введите загаданное число от 1 до 1000: ");
                int num_people2 = int.Parse(Console.ReadLine()!);
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
            

        }
    }
}
