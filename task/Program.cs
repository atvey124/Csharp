Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine()!);
Random rnd_num = new();
int[] arrr = new int[size];
for(int i = 0;i < size;i++)
{
    arrr[i] = rnd_num.Next(-30,1000);
} 
int[] arr_function(int[] arrr) // функция будет принимать массив,который нужно отсортировать и возвращать уже отсортированный
{
    
    for ( int i = 0;i < arrr.Length;i++) // цикл внутри которого будет цикл,который исчет минимальный элемент в текущем диапазоне
    {
        int index_min = i; // индекс минимального элемента в текущем диапазоне (j)
        for ( int j = i;j < arrr.Length;j++) // j - индекс минимального элемента
        {
            if ( arrr[j] < arrr[index_min]) // если текущий элемент,меньше минимального,то он становится минимальным
            {
                index_min = j;
            }
        }
        if (arrr[i] == arrr[index_min]) // если произошло так,что минимальным в текущем диапазоне элементом является такое же число,как и index_min
        {
            continue; //тогда мы просто переходим к другой строке кода,continue - оператор который просто ничего не делает,который указывает на то,что нужно просто перейти к другой строке кода(дальше)
        }
        int temp = arrr[i]; // переменная которая будет заменять текущий элемент,на минимальный из диапазона(j)
        arrr[i] = arrr[index_min]; // замена текущего индекса,на минимальный элемент
        arrr[index_min] = temp;

    }
    return arrr;
}
Console.WriteLine($"Начальный массив:  {string.Join(", ", arrr)}"); // метод string.Join(", ",arrr) - объединяет все элементы массива в одну строку, так же он принимает два параметра,первый это разделитель(с помощью чего мы хотим разделять строку,указывается он в ""),второй это сам массив. Первый элемент от второго отделяется запятой(,)
Console.WriteLine($"Ответ: {string.Join(", ", arr_function(arrr))}");


































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

