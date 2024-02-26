Console.WriteLine("Приветствую тебя,в данной игре тебе нужно угадать загаданное программой число,каждый раз когда ты угадаешь,тебе будет даваться столько очков,сколько чисел в диапазоне,цель - набрать 1000 очков");

int number_of_functions = 0;
long FactorialFunction(int num)
{
    long sum = 0;
    for(int i = 1;i < num - 1;i++)
    {
        sum += i * i + 1;
    }
    number_of_functions++;
    return sum;
}

long SquareNum(int num)
{
    
    number_of_functions++;
    return num * num;
}

string SymbolsStr(int num)
{
    string str = "";
    for(int i = 0;i < num - 1;i++)
        str += "s";
    number_of_functions++;
    return str;
}

long four_dimensional_matrix(int num)
{
    long num1 = num * num;
    return num * num1;
}



















int complete_game = 0;

int simple_game(int[] best_score)
{
    int max = best_score.Max();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Ваш лучший результат: {max}");
    int score = 0;
    int complite_level = 1;
    while(true)
    {
        while(true)
        {
            try
            {
                int from = 0;
                int to = 100 * complite_level;
                Random rnd = new();
                Console.Write("Введи количество попыток,каждая попытка отнимает одно очко: ");
                int attempt = int.Parse(Console.ReadLine()!);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Текущий диапазон от {from} до {to}");
                score = score - attempt;
                int random_number = rnd.Next(from,to + 1);
                Console.WriteLine(random_number);
                Random rnd1 = new();
                int size = rnd1.Next(1,number_of_functions + 1);

                switch(size)
                {
                    case 1:
                        Console.WriteLine($"ПОДСКАЗКА:число равно размерности матрицы на {four_dimensional_matrix(random_number)} элементов");
                        break;
                    case 2:
                        Console.WriteLine($"ПОДСКАЗКА:квадратом этого числа является: {SquareNum(random_number)}");
                        break;
                    case 3:
                        Console.WriteLine($"ПОДСКАЗКА:факториалом этого числа равна сумма {FactorialFunction(random_number)} ");
                        break;
                    case 4:
                        Console.WriteLine($"Подсказка:число равно символам в этой строке: {SymbolsStr(random_number)}");
                        break;
                }

                if(complite_level % 3 == 0)
                {
                    Random rnd2 = new();
                    int random_task = rnd2.Next(1,2 + 1);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Каждые два уровня будет даваться шанс заработать дополнительные очки(200),ответив на один вопрос");
                    Console.WriteLine("Если же ты дашь не верный ответ,ты проиграешь");
                    Console.WriteLine("Примешь ли ты участие(да/нет): ");
                    string yes_no = Console.ReadLine()!;
                    yes_no.ToLower();
                    if(yes_no == "да")
                    {
                        switch(random_task)
                        {
                            case 1:
                                Console.Write("чем в программирование является формула Эйлера,ответ должен состоять из одного слова: ");
                                string answer = Console.ReadLine()!;
                                answer.ToLower();
                                if(answer == "цикл")
                                {
                                    Console.WriteLine("Поздравляю ты выиграл и заработал 200 очков");
                                    score += 200;
                                    Console.WriteLine($"Текущие очки {score}");
                                }
                                else
                                {
                                    Console.WriteLine("Ты проиграл");
                                    Console.WriteLine($"Всего очков ты набрал: {score}");
                                    complete_game++;
                                    return score;
                                }
                                break;
                            case 2:
                                Console.Write("Что такое http: в url адресе,ответ должен состоять из одного слово: ");
                                string answer1 = Console.ReadLine()!;
                                answer1.ToLower();
                                if(answer1 == "протокол")
                                {
                                    Console.WriteLine("Поздравляю ты выиграл и заработал 200 очков");
                                    score += 200;
                                    Console.WriteLine($"Текущие очки {score}");
                                }
                                else
                                {
                                    Console.WriteLine("Ты проиграл");
                                    Console.WriteLine($"Всего очков ты набрал: {score}");
                                    complete_game++;
                                    return score;
                                }
                                break;

                        }
                    }

                }

                while(attempt > 0)
                {
                    try{
                        Console.Write($"Угадай число(lv{complite_level}),осталось попыток -- {attempt}: ");
                        
                        int input_num = int.Parse(Console.ReadLine()!);
                        if(input_num == random_number)
                        {
                            complite_level++;
                            Console.WriteLine();
                            Console.WriteLine($"Поздравляю,ты выиграл и перешол на уровень {complite_level}");
                            score += to;
                            Console.WriteLine($"Текущий счет {score}");
                                    
                            break;
                        }
                        else if(input_num < random_number)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Загаданное число больше");
                            
                            attempt--;
                        }
                        else if(input_num > random_number)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Загаданное число меньше");
                            attempt--;
                        }
                        Console.WriteLine();
                    }
                    catch
                    {
                        Console.WriteLine("Ты ввел не корректный тип данных,будь внимателен");
                    }

                }
                if(score >= 1000 && score <= 1500)
                {
                    Console.WriteLine("Ты прошел игру,поздравляю");
                    Console.WriteLine($"Всего очков ты набрал: {score}");
                    Console.WriteLine("Хочешь продолжить в свободном режиме?(да/нет): ");
                    string input_str = Console.ReadLine()!;
                    if(input_str == "да")
                    {
                        continue;

                    }
                    else
                    {
                        Console.WriteLine("Игра окончена");
                        complete_game++; 
                        return score;
                    }
                        
                        
                }
                if(attempt == 0)
                {
                    Console.WriteLine($"Ты проиграл на уровне {complite_level}");
                    Console.WriteLine($"Набрав очков: {score}");
                }
                Console.WriteLine("Хочешь продолжить(Да/Нет)?: ");
                string stop = Console.ReadLine()!;
                stop.ToLower();
                if(stop == "да")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Всего очков ты набрал: {score}");
                    complete_game++; 
                    return score;
                }
            }

            catch
            {
                Console.WriteLine("Ты ввел не корректный тип данных,будь внимателен");
            }

            
                        
        }
    }    
}





int[] game_score = new int[100];
game_score[complete_game] = simple_game(game_score);


































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






