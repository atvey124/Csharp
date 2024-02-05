// задача,где надо найти все гластные буквы в массиве который ввел пользователь и вывести их в другой массив

/*
Console.Write("Введите длину массива символов: ");

int size = int.Parse(Console.ReadLine()!);

char[] char_arr = new char[size]; // создание массива символов,передача туда длины,что ввел пользователь

void char_generator(char[] char_arr) // функция заполнения массива
{
    try
    {
        char char_input; // то число,что ввел пользователь инициализировано до цикла,чтобы каждый раз не создавать новую и новую переменную в цикле(нагружает память)

        for(int i = 0;i < char_arr.Length;i++) // цикл который пройдет от начала и до конца
        {
            Console.Write("Введите символ: ");

            char_input = char.Parse(Console.ReadLine()!); // и заполнит массив теми символами,что ввел пользователь,важно сконвертировать их,поскольку все,что вводится с терминала является типом данных(string)

            char_arr[i] = char_input;

            Console.WriteLine();
        }
    }
    catch
    {
        Console.WriteLine("Символ состоит из одной буквы,цифры,спецсимвола");
    }
}
*/



Console.Write("Введите слово: ");

string input_word = Console.ReadLine()!; // слово в котором нужно найти символы

Console.Write("Введите символы которые нужно: ");

string find_latter = Console.ReadLine()!; // символы которые нужно найти(в виде сроки,потому что строка - это массив символов)

char[] letter_on_charr_arr(string find_latter,string input_word) // будет возвращать новый массив из гласных букв
{
    int quantity = 0; // сколько всего букв найдено в слове

    for(int i = 0;i < find_latter.Length;i++) // пока не закончатся символы в слове (input_word)
    {
        if (input_word.Contains(find_latter[i])) // проверка на то содержит ли input_word(слово в котором надо найти определенные символы(find_latter)),поскольку с консоли вводится строка,то мы идем по ее символам
        {
            quantity++;

        }
    }

    int index = 0;

    char[] vowel_arr = new char[quantity]; // длина массив это число букв которые удалось найти

    for(int j = 1;j < find_latter.Length;j++)
    {
        for(int i = 0;i < input_word.Length;i++)
        {
            if (input_word.Contains(find_latter[j]))
            {
                vowel_arr[index] = find_latter[j]; // заносим в массив символ,который нашли,если условие правдиво,на той букве на которой мы сейчас,то тогда заносим в массив букву на которой мы сейчас находимся
                index++;
            }


        }
    }
    return vowel_arr;

}


/*
char_generator(char_arr);

Console.WriteLine($"Получившейся массив пользователя : {string.Join(", ",charr_arr)}");
*/

Console.WriteLine();

char[] vowel_arr = letter_on_charr_arr(find_latter,input_word);

Console.WriteLine($"Массив с буквами: {string.Join(", ",vowel_arr)}" + $" Всего букв удалось найти: {vowel_arr.Length}");





























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
