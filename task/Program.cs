
string[] figure_white = new string[8]{"ладья_бел","конь_бел","слон_бел","король_бел","ферзь_бел","слон1_бел","конь1_бел","ладья1_бел"};
string[] figure_black = new string[8]{"ладья_черн","конь_черн","слон_черн","король_черн","ферзь_черн","слон1_черн","конь1_черн","ладья1_черн"};
string[] pawn_white = new string[8]{"пешка_бел1","пешка_бел2","пешка_бел3","пешка_бел4","пешка_бел5","пешка_бел6","пешка_бел7","пешка_бел8"};
string[] pawn_black = new string[8]{"пешка_черн1","пешка_черн2","пешка_черн3","пешка_черн4","пешка_черн5","пешка_черн6","пешка_черн7","пешка_черн8"};
char[] letters = new char[8]{'A','B','C','D','E','F','G','H'};

string[,] GenerateFunction(string[] figure_white,string[] figure_black,string[] pawn_white,string[] pawn_black)
{
    int size_field = 8;
    string[,] field = new string[size_field,size_field];
    int index = 0;
    while(index < size_field)
    {
        if(index <= 1)
        {
            for(int i = 0;i < figure_white.Length;i++)
            {
                field[index,i] = figure_white[i];
            }
            index++;
            for(int o = 0;o < pawn_white.Length;o++)
            {
                field[index,o] = pawn_white[o];
            }
            index++;
        }
        if(index >= 6)
        {
            for(int j = 0;j < figure_black.Length;j++)
            {
                field[index,j] = figure_black[j];
            }
            index++;
            for(int h = 0;h < pawn_black.Length;h++)
            {
                field[index,h] = pawn_black[h];
            }
            index++;
        }
        if(index > 1 && index < 6)
        {
            for(int l = 0;l < size_field;l++)
            {
                field[index,l] = "o";
            }
            index++;
        }


    }

    return field;
}

void PrintFunction(string[,] field,char[] letters)
{
    Console.WriteLine("    " + string.Join("            ",letters));
    for(int i = 0;i < field.GetLength(1);i++)
    {
        Console.Write("---------------");
    }

    Console.WriteLine();
    int size_pix = 120;
    int str_length_pix = 0;
    int number_of_spaces_in_zero = 8;
    int number_of_spaces_in_shapes = 4;
    for(int i = 0;i < field.GetLength(0);i++)
    {   
        Console.Write(i + 1);
        Console.Write("|");
        for(int j = 0;j < field.GetLength(1);j++)
        {
            if(j + 1 != field.GetLength(1))
            {
                if(field[i,j] == "o")
                {
                    Console.Write(field[i,j]);
                    Console.Write("        ");
                    str_length_pix += field[i,j].Length + number_of_spaces_in_zero;

                }
                else
                {

                    Console.Write(field[i,j] + "    ");
                    str_length_pix += field[i,j].Length + number_of_spaces_in_shapes;
                }
                
            }
            else if(j + 1 == field.GetLength(1))
            {
                if(field[i,j] == "o")
                {
                    Console.Write(field[i,j]);
                    str_length_pix += field[i,j].Length;

                }
                else
                {
                    Console.Write(field[i,j]);
                    str_length_pix += field[i,j].Length;
                }
                
            }
        }
        for(int k = 0;k < (size_pix - str_length_pix);k++)
        {
            Console.Write(" ");
        }
        Console.Write("|");
        Console.WriteLine(i + 1);
        str_length_pix = 0;
    }
    
    for(int j = 0;j < field.GetLength(1);j++)
    {
        Console.Write("---------------");
    }
    Console.WriteLine();
    Console.WriteLine("    " + string.Join("            ",letters));
    
}

int size_all_figure = figure_white.Length + figure_black.Length + pawn_white.Length + pawn_black.Length;
string[] all_figure = new string[size_all_figure];

int index2 = 0;

while(index2 < size_all_figure)
{
    for(int i = 0;i < figure_white.Length;i++)
    {
        all_figure[index2] = figure_white[i];
        index2++;
    }
    for(int j = 0;j < figure_black.Length;j++)
    {
        all_figure[index2] = figure_black[j];
        index2++;
    }
    for(int k = 0;k < pawn_black.Length;k++)
    {
        all_figure[index2] = pawn_white[k];
        index2++;
    }
    for(int h = 0;h < pawn_black.Length;h++)
    {
        all_figure[index2] = pawn_black[h];
        index2++;
    }

}
string[,] field = GenerateFunction(figure_white,figure_black,pawn_white,pawn_black);
PrintFunction(field,letters);

string[] chees(string[,] field,char[] letters,string[] all_figure)
{
    string[] chess_part = new string[2];
    string[,] move_arr = field;
    while(true)
    {

        int index_player = 0;
        Console.WriteLine($"Ход игрока {index_player}");
        Console.WriteLine("Введите какой фигурой хотите походить: ");
        string figure_input = Console.ReadLine()!;
        int figure_current = 0;
        int figure_current_str = 0;
        Console.WriteLine("Введите на какую позицию хотите походить: ");
        char position = char.Parse(Console.ReadLine()!);
        int move = 0;
        Console.WriteLine("На какой строке: ");
        int move_str = int.Parse(Console.ReadLine()!);

        for(int k = 0;k < field.GetLength(0);k++)
        {
            for(int i = 0;i < field.GetLength(1);i++)
            {
                if(field[k,i] == figure_input)
                    figure_current_str = k;
            }
        }
        
        for(int i = 0;i < field.GetLength(0);i++)
        {
            for(int j = 0;j < field.GetLength(1);j++)
            {
                if(figure_input == field[i,j])
                    figure_current = j;

            }
        }
        for(int h = 0;h < letters.Length;h++)
        {
            if(position == letters[h])
            {
                move = h;
            }
        }
        
        string temp = move_arr[move_str - 1,move];
        move_arr[move_str - 1,move] = move_arr[figure_current_str,figure_current];
        move_arr[figure_current_str,figure_current] = temp;
        PrintFunction(move_arr,letters);
        index_player = 1;

    }
    return chess_part;
}


chees(field,letters,all_figure);






















/*

























Console.WriteLine("Приветствую тебя,в данной игре тебе нужно угадать загаданное программой число,каждый раз когда ты угадаешь,тебе будет даваться столько очков,сколько чисел в диапазоне,цель - набрать 10000 очков.Так же на каждом уровне тебе будет даваться подсказка,чем дальше уровень тем подсказки разнообразнее,так же подсказка может быть не дана вовсе");

int number_of_functions = 1;
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
    number_of_functions++;
    long num1 = num * num;
    return num * num1;
}


int Corner(int num)
{
    number_of_functions++;
    return num * 4;
}


int free_mode = 0;
int complete_game = 0;

int simple_game(int free_mode)
{

    Console.WriteLine();
    Console.WriteLine();

    int score = 0;
    int complite_level = 1;
    while(true)
    {
        while(true)
        {
            try
            {

                Random rnd3 = new();
                int random_range = rnd3.Next(1,100);
                int from = 0;
                int to = 100 * random_range + 1;
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
                        Console.WriteLine($"ПОДСКАЗКА:число равно размерности трехмерной матрицы на {four_dimensional_matrix(random_number)} элементов");
                        break;
                    case 2:
                        Console.WriteLine($"ПОДСКАЗКА:квадратом этого числа является: {SquareNum(random_number)}");
                        break;
                    case 3:
                        Console.WriteLine($"ПОДСКАЗКА:факториалом этого числа равна сумма {FactorialFunction(random_number)} ");
                        break;
                    case 4:
                        Console.WriteLine($"ПОДСКАЗКА:число равно символам в этой строке: {SymbolsStr(random_number)}");
                        break;
                    case 5:
                        if(random_number % 4 == 0)
                        {
                            Console.WriteLine($"ПОДСКАЗКА:данное число представляет собой одну сторону квадрата,площадь которого {Corner(random_number)}");
                        }
                        break;   
                }
                if(complite_level % 3 == 0)
                {
                    Random rnd2 = new();
                    int random_task = rnd2.Next(1,2 + 1);

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Каждые три уровня будет даваться шанс заработать дополнительные очки(200),ответив на один вопрос");
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
                            Console.WriteLine($"Поздравляю,ты выиграл и перешёл на уровень {complite_level}");
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

                if(score >= 10000 && free_mode == 0)
                {
                    free_mode++;
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
                    Console.WriteLine($"Ты проиграл на уровне {complite_level},загаданное число - {random_number}");
                    Console.WriteLine($"Набрав очков: {score}");
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
                
            }

            catch
            {
                Console.WriteLine("Ты ввел не корректный тип данных,будь внимателен");
            }            
        }
    }    
}



simple_game(free_mode);


*/
































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






