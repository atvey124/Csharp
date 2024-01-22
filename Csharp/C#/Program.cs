﻿// типы данных в c#
using System.Transactions;

int integer = 1245; // цело численные
bool boolian = false; // логические значения true false 
char character = '!'; // знаки,пишутся внутри ''
double double1 = 5.55; // дробные 
string string1 = "Hi"; // строки
//null - тип данных null это посути пустая ячейка в базе данных или же отсутствие значения
Random rnd = new(); // генератор случайного числа,где rnd - имя переменной,данный тип данных является ссылочным,new() - выделение памяти под этот объект,таким образом используя переменную rnd можно обратиться к генератору случайных чисел
int value = rnd.Next(1,100); // далее создаем новую переменную или используем уже существующую и передаем туда,нашу переменную типа Random,далее идет метод .Next(1,100) - в скобочках указываем диапазон случайных чисел,от какого до какого,верхняя граница не включительно
Console.WriteLine(integer);
Console.WriteLine(boolian);
Console.WriteLine(character);
Console.WriteLine(double1);
Console.WriteLine(string1);




                                                                                        // бинарные операции 
int num1 = 12;
int num2 = 13;
int results = num1 + num2; 
Console.WriteLine(results); // новая переменная будет иметь тип данных 'int',поскольку в бинарной операции два операнда имеют одинокавый тип данных,результат нужно самому помещать в этот тип данных,пример на 19 строке


int integer_num = 10;
double double_num = 10.5;
double sum_integer_double = integer_num + double_num; // в случае если типы данных у операндов будут разные,результат будет иметь тип данных того операнда,который имеет более широкий спектр возможностей('более вместительный' операнд),переменную выражающую результат нужно самому поместить в этот тип данных(всегда более вместительный)
Console.WriteLine(sum_integer_double); // в результате этого произведения результат(переменная sum_integer_double) будет иметь тип данных 'double',поскольку является более вместитльным 

long long_num = 1000;
int integer_num1 = 15;
long sum_long_integer = long_num + integer_num1; 
Console.WriteLine(sum_long_integer); // в этом случае результат произведения(переменная sum_long_integer) будет иметь тип данных 'long',по той же причине

double double_num2 = 10;
int integer_num3 = 8;
double sum_double = double_num2 / integer_num3; // при делении лучше всегда использовать дробный тип данных(double) в одном из операндов
Console.WriteLine(sum_double); // результатом будет дробный тип данных




                                                                                        // операторы условия 
double condition1 = 15;
double condition2 = 15.5;
if (condition1 < condition2) // условие всегда пишется в круглых скобках 
{
    Console.WriteLine(condition2); // после условия пишутся фигурные скобки,обозначающие true,тоесть то,что будет происходить если условие верно,в фигурных скобках код пишется через табуляцию,в данном примере переменная condition2 больше,соотвественно в выводе мы получаем именно его
}
else
{
    Console.WriteLine(condition1); // после первых фигурных скобок обычно пишется else,после чего опять фигурные скобки,которые обозначают,что будет происходить если условие не верно,в фигурных скобках код пишется через табуляцию
}




                                                                                        // операторы цикла
int N = 30;
int index = 1;
while (index <= N) // условие цикла так же должно быть в круглых скобках
{
    Console.WriteLine(index); // после чего в фигурных скобках пишутся действия которые будут выполняться пока цикл не будет прерван,тоесть условие нарушиться
    index = index + 1; // итерация в цикле чаще всего выполняется с помощью вспомогающей переменной,которая обозначает - один проход по циклу

}
Console.WriteLine(index); // после цикла пишется то,что будет выполняться когда цикл будет прерван,в конкретном примере это не требуется


// решение задачи на нахождение большего числа в массиве,используя цикл for
int[] array100 = {234,54,5,5,45,45,45,5454545,54,54}; // объявление массива
int max_array_num = array100[0];
for(int j = 0; j < array100.Length;j++) // (int j = 10; - объявление переменной внутри цикла),(j < n; - условие цикла),(j++ - один шаг), переменная созданная внутри цикла 'for' - имеет ту же область определенния,что и сам цикл 'for',кроме того цикл for изменяемый,тоесть можно менять объекты внутри цикла,к примеру объекты массива
{
    if (max_array_num < array100[j]) 
    {
        max_array_num = array100[j];
    } // j++; в цикле for не используется поскольку пишется в аргументе цикла
}
Console.WriteLine("Цикл for - наибольшее число в массиве: " + max_array_num);


// while(true) // while(true) - означает,что цикл будет выполняться бесконечно,пока не будет достигнута верхняя граница,тоесть пока не закончится массив и т.д., цикл while поддерживает изменение массива,тоесть можно не только узнавать данные из массива,но и менять их в цикле
{
    Console.WriteLine("бесконечный цикл");
}


int[] array1001 = { 43,54,54 };
foreach ( int e in array1001) // foreach цикл позволяет перебрать все данные в массиве,при каждом шаге в него будет заноситься следующий индекс в массиве и так до последнего,шаг указывать не нужно,он всегда - 1, in означает в какой именно переменной(массиве) мы собираемся перебирать данные(тип данных у переменной которая инициализируется в массиве,должен совпадать с типом данных переменной(массива))!
{
    Console.WriteLine(e); // каждый следующий элемент массива копируется в переменную(e),так же в foreach нельзя изменять массив,тоесть он доступин только для чтения данных,не для их изменения
}


                                                                                        // методы
double i = 1;
                                                                                     
Console.WriteLine(i); // данный метод позволяет вывести что-либо в терминал по вертикале
Console.Write(i); // данный метод позволяет вывести что либо в терминал по горизонтали
Console.Write(' '); // так же в данный метод можно вывести такой тип данных как char,можно вывести любой тип данных
Convert.ToInt32(Math.Floor(i)); // метод Math.Floor - округляет в меньшую сторону число типа double,в скобочках метода указывается само число либо же переменная,перед этим число нужно конвертировать в тип данных 'int'


int index10 = 1;
int n2 = 12;
while (index10 <= n2)
{
    Console.Write(index10);
    Console.Write(' ');
    index10 =++ index10;
} // например таким образом будет выглядеть предыдущая задача,но уже с использованием этих методов(в терминале это будет выглядеть так: 1 2 3 4 5 6 7 8 9 10 11 12)


Console.ReadLine(); // метод позволяющий вводить значения с терминала(input в python),тип данных после ввода по умолчанию string


// небольшая задача с использованием Console.ReadLine(),по нахождению принадлежности второго числа к квадрату первого
Console.Write("Введите первое число,которое хотите возвести в квадрат: "); 

int convert_num1 = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 метод позволяющий конвертировать переменные в другой тип данных,в конкретном примере в тип данных 'int',где 32 обозначает разрядность

Console.Write("Введите второе число,которое хотите проверить на квадрат первого: ");

int convert_num2 = Convert.ToInt32(Console.ReadLine()); // в параметр конвертора можно сразу передать Console.WriteLine()
if (convert_num1 * convert_num1 == convert_num2)
{
    Console.WriteLine("Число 1 является квадратом числа 2");
}
else
{
    Console.WriteLine("Число 1 не является квадратом числа 2");
}


int test = 43!; // знак '!' после строки кода,но перед ';' - позволяет убрать пунктирную линию,обозначающую неверную структуру кода
Console.WriteLine(test);


// int.Parse() так же метод для конвертации в другой тип данных,где вместо int можно задать другой тип данных

// так та же задача будет выглядеть,но уже с этим методом


Console.Write("Введите первое число,которое хотите возвести в квадрат: "); 

int test1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число,которое хотите проверить на квадрат первого: ");

int test2 = int.Parse(Console.ReadLine()!); 
if (test1 * test1 == test2)
{
    Console.WriteLine("Число 1 является квадратом числа 2");
}
else
{
    Console.WriteLine("Число 1 не является квадратом числа 2");
}

// еще одна небольшая задача с использованием Parse
Console.Write("Введите число N,между -N и N будут показаны все целые числа: ");
int N_number = int.Parse(Console.ReadLine()!);
int count = -N_number;
while (count != N_number)
{   
    Console.Write(count + " ");
    count++;  // count++ метод эквивалентный += в python,или же эквивалент count = count + 1   
}


// и еще одна задача с использованием конвертора int.Parse(),которая позволяет при вводе трехзначного числа пользователем,убрать вторую цифру в этом числе,ПРИМЕР: 156 -> 16
Console.Write("Введите трехзначное число,вторую цифру в котором нужно убрать: ");
int three_digit = int.Parse(Console.ReadLine()!); // принимает число,которое пользователь ввел с терминала и конвертирует его в целочисленный тип данных
Console.WriteLine(three_digit / 100 * 10 + three_digit % 10); // операцией three_digit / 100 мы получаем первую цифру в числе(деление с использованием '/' уменьшает число на количество нулей в делители,в данном случае деление на 100,поэтому число уменьшилось на 2 цифры),умножение на 10 нужно для корректного результата,деление с использованием '%',позволяет узнать последнюю цифру в числе(так же зависит от количества нулей в делителе)
// оператор '/' уменьшает число на столько цифр сколько стоит в делителе
// оператор '%' забирает последнюю цифру в числе
// ПРИМЕР: 123 / 10 -> 12, 123 / 100 -> 1, 123 / 1000 -> 0, 123 % 10 -> 3, 123 % 100 -> 23, 123 % 1000 -> 123


// пример задачи с использованием данных методов и метода Math.Pow(),который принимает в скобках два аргумента,первый что возводим в степень,второй на сколько.ПРИМЕР: Math.Pow(32,43)
Console.Write("Введите трехзначное число,вторую цифру в котором нужно возвести в степень третьего числа: ");
int num_num = int.Parse(Console.ReadLine()!);
if (num_num >= 100 && num_num < 1000) // создаем проверку трехзначное ли число ввел пользователь
{
    int num22 = num_num % 100 / 10; // если да, то находим вторую цифру в числе(отделяя две последние и деля их на 10 без остатка,таким образом находим вторую цифру в числе)
    int num33 = num_num % 10; // находим третью цифру,отделяя ее от чисда
    double results1 = Math.Pow(num22,num33); // считаем результат,где в аргументы кладем второе и третье число
    Console.WriteLine("Ответ: " + results1);
}
else // если пользователь ввел не трехзначное число - выводим соответствующий текст
{
    Console.WriteLine("Вы ввели не трехзначное число");
}


// пример с задачи с использованием оператора '%',который показывает остаток от деления
Console.Write("Введите первое число которое хотите проверить на крастность ко второму: ");
int first_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second_num = int.Parse(Console.ReadLine()!);
if (first_num % second_num == 0) // если деление без остатка,выводим соотвествующий текст
{
    Console.WriteLine("Число 1 кратно числу 2");
}
else // если деление с остатком - показываем его
{
    Console.WriteLine("Число 1 не кратно числу 2,остаток от деления равен: " + first_num % second_num);
}


// еще одна задача с использованием операторов '/' и '%'
Console.Write("Введите число третью цифру от коцна которого вы хотите узнать: ");
int num_three = int.Parse(Console.ReadLine()!);
if (num_three / 100 != 0) // проверяем есть ли третья цифра в числе
{
    Console.WriteLine("Ответ: " + (num_three / 100 % 10)); // если да то показываем ее пользователю, / 100 мы сокращаем число до десятка, % 10 мы показываем остаток в этом десятке -> тоесть третье число
}
else
{
    Console.WriteLine("Третьей цифры c конца нет"); // если нет выводим соответствующий текст
}


// еще одна простая задача,на нахождение кратности введённого пользователем числа на 7 и 23,данный способ можно оптимизировать с помощью оператора &&,но я пока не умею :)
Console.Write("Введите число которое хотите проверить на крастность 7 и 23: ");
double multiplicity = int.Parse(Console.ReadLine()!);
if (multiplicity % 7 == 0) // проверяем кратно ли число 7
{
    if (multiplicity % 23 == 0) // если число кратно 7,проверяем кратно ли оно 23
    {
        Console.WriteLine("Число кратно и 23 и 7"); // если число кратно и тому и тому,то выполняем это действие
    }
}
else
{
    Console.WriteLine("число не кратно либо 7 либо 23"); // если же число не кратно,либо тому,либо тому,то выводим соответсвующий текст
}




                                                                                        // array,массивы
int[] array = new int[7]; // int[] - объявление массива(создание),где int - тип данных этого массива,далее new int[7] - объявление сколько ячеек памяти будет в этом массиве,int - все так же тип данных,важно помнить,что индекс в массиве начинается с нуля,тоесть для 7 ячеек памяти(мест в массиве),последним индексом будет - 6
int[] array2 = new int[7] {43,54,65,65,45,54,54}; // {43,54,65,65,45,54,54} - заполнение массива данными сразу при создании,удобный способ однако подходит только в тех случаях,когда мы заранее точно знаем сколько данных(ячеек памяти - мест в массиве) будет
int[] array3 = {43,54,65,65,45,54,54}; // способ выше можно выразить и таким образом,не используя оператор new int(тип данных массива),как и со способом выше,мы сразу ограничиваем массив на 7 элементов
Console.WriteLine(array3[3]); // array[3] - обращение к индексу массива


// пример простой задачи с использвоанием массива,в которой при вводе пользователем числа N,программа заполнит массив целыми числами от 1 до этого числа N
Console.Write("Введите число N: ");

int N_number1 = int.Parse(Console.ReadLine()!); 
int[] array4 = new int[N_number1]; // длина массива фиксируется введенным пользователем числом
int index1 = 0; // счетчик
Console.Write("Ответ: ");

while (index1 < N_number1) 
{
    array4[index1] = index1 + 1; // поскольку индекс в массиве начинается с нуля,добавляем 1 после каждого шага,чтобы 'не отставать'
    Console.Write(array4[index1] + " "); // выводим индекс массива каждый шаг
    index1++; // каждый шаг увеличиваем счетчик,который мы передали индексу массива
}


Console.WriteLine("просто сообщение,чтобы не было путаницы в терминале");

// еще одна задача используя массив,которая покажет,в заранее известном массиве,четные и нечетные числа в массиве
int[] array_num = {12,436,65,76,87,87,87,87,54,54};
i = 0;
while ( i < array_num.Length)
{
    if (array_num[i] % 2 == 0)
    {   
        Console.Write("Чётные числа: ");
        Console.Write(array_num[i] + " ");
    }
    else
    {
        Console.Write("Нечётные числа: ");
        Console.Write(array_num[i] + " ");
    }
    i++;
}


// задача на нахождение большего числа в массиве
int[] array_dumbells = { 434,5454,5,45,4,54,5,45,4,54,54,54,54 };
int i1 = 0;
int max = array_dumbells[0];
while (i1 < array_dumbells.Length)
{
    if ( array_dumbells[i1] > max )
    {
        max = array_dumbells[i1];  
    }
    i1++;
}
Console.WriteLine("Самое большое число в массиве: " + max);


// задача на нахождение большего числа и его индекса
int[] array_dumbells1 = { 434,5454,565664,45,4,54,5,45,4,54,54,54,54 };
int i2 = 0;
int max1 = array_dumbells1[0];
int max_index = array_dumbells1[0];
while (i2 < array_dumbells1.Length)
{
    if ( array_dumbells1[i2] > max1 )
    {
        max1 = array_dumbells1[i2];
        max_index = i2; 
    }
    i2++;
}
Console.WriteLine("Самое большое число в массиве: " + max1 +  " Самый больший индекс в массиве: " + max_index);


// задача на нахождение большего и меньшего числа в массиве и их индекса
int[] array_dumbells2 = { 434,5454,565664,45,1,54,5,45,4,54,54,54,54 };
int i3 = 0;
int max2 = array_dumbells2[0];
int max_index1 = array_dumbells2[0];
int min_num = array_dumbells2[0];
int min_index = array_dumbells2[0];
while (i3 < array_dumbells2.Length)
{
    if ( array_dumbells2[i3] > max2 )
    {
        max2 = array_dumbells2[i3];
        max_index1 = i3;
    }
    if ( array_dumbells2[i3] < min_num)
    {
        min_num = array_dumbells2[i3];
        min_index = i3;
    }
    i3++;
}
Console.WriteLine("Самое большое число в массиве: " + max2 +  " Самый больший индекс в массиве: " + max_index1);
Console.WriteLine("Самое меньшее число в массиве: " + min_num + " Самый меньший индекс в массиве: " + min_index);


// задача на нахождение второго по величине числа в массиве и его индекса
int[] array_more = {43,54,65,245,543354422,53535353,3535,43434};
int i4 = 0;
int max_num = array_more[0];
int max_num_index = 0;
int second_max = array_more[0];
int second_max_index = 0;
while (i4 < array_more.Length)
{
    if ( array_more[i4] > max_num)
    {
        max_num = array_more[i4];
        max_num_index = i4;
    }
    i4++;
}  
i4 = 0;
while (i4 < array_more.Length)
{
    if (second_max != max_num)
    {
        if (array_more[i4] > second_max)
        {
            second_max = array_more[i4];
            second_max_index = i4;
            i4++;
        }
    }
    i4++;
}
        
Console.WriteLine("Самое большое число в массиве: " + max_num +  " Самый больший индекс в массиве: " + max_num_index);
Console.WriteLine("Второе по величине число в массиве: " + second_max + " Второй по величине индекс в массиве: " + second_max_index);


// еще одна задача с использованием массива(array)
int [] array_10 = {54,654,87,43,768,5434,763,6586,8,67,6,4,32,5,7,2,1,0,2,2,2}; // инициализация массива
int i11 = 0; // счетчик
int current_index = 0; // счетчик сколько раз число всречается в массиве
Console.Write("Введите число,которое есть в массиве: ");
int num_people100 = int.Parse(Console.ReadLine()!); // конвертируем введенное пользователем число в тип данных(int)
while (i11 < array_10.Length) // пока счетчик меньше длины массива,выполняем цикл
{
    if (num_people100 != array_10[i11]) // если число не равно введенному пользователем,добавляем +1 к счетчик
    {
        i11++;
    }
    else // если равно,то фиксируем это,добавляя в переменную current_index + 1,таким образом мы узнаем сколько число встречалось раз в массиве
    {
        current_index++;
        i11++;
    }
}

Console.WriteLine("Данное число встречается в массиве: " + current_index + " раз");


// еще одна задача с использованием массива(array),которая меняет положительные числа на отрицательные и наоборот
int[] a_array = {-1,-2,-3,-4,-5,0,0,-6,1,2,3,4,5,6,-100};
int index_a = 0;
while (index_a < a_array.Length)
{
    a_array[index_a] = a_array[index_a] * -1; // домножение на -1 меняет положительное число на отрицательное и отрицательное на положительное(минус на минус дает плюс)
    Console.Write(a_array[index_a] + " ");
    index_a++;
}

// еще одна задача с использованием массива[array],где первое число складывается с последним,второй с предпоследним и так далее
Console.Write("Введите количество элементов массива: ");
int count1 = int.Parse(Console.ReadLine()!);
int[] new_massive = new int[count1]; // создание массива и передача туда данных введенных пользователем,new int[count1] - означает,что количество элементов массива будет ограничено тем,что ввел пользователь.new int[],где [] - длина массива

Random random_number_array = new(); // метод рандом
Console.Write( "Массив: " + "[" );
for (int i40 = 0;i40 < count1;i40++) // заполнение массива случайными числами,с помощью счетчика(заполнили одно число,перешли к другому и так далее пока не будет достигнута граница массива,введенная пользователем)
{
    new_massive[i40] = random_number_array.Next(-10,10); 
    Console.Write(new_massive[i40] + " "); // вывод массива в терминал,чтобы видеть правильно ли решено
}
Console.WriteLine("]");
int b = 0; // переменная b это первое число в массиве(индекс первого числа в массиве)
count1--; // переменная count1 это последнее число в массиве(тоже используется как индекс),поскольку индекс начинается с нуля а не с 1,то мы уменьшаем его на 1
Console.Write(" Ответ: ");
while(b < count1 && b != count1) // далее пока
{
    new_massive[b] = new_massive[b] + new_massive[count1]; // далее будем первое число складывать с последним
    Console.Write(new_massive[b] + " "); //  и выводить на экран
    b++; // увеличиваем первое число на один
    count1--; // уменьшаем последнее число на 1,пока первое и последнее не встретяться
}
if ( b != 0 && b == count1) // если же первое и последнее число встретились,что означает,что какому-то элементу нет пары,то мы это проверяем и выводим следующий текст
{
    Console.WriteLine($",Элемент {new_massive[b]} c индексом {b} не имеет пары");
}


// еще одна задача с использованием массива(array),где дано трехзначное число,нужно цифры этого числа занести в массив так,чтобы последняя цифра в массиве встала на индекс 0,предпоследняя на индекс 1,последняя на индекс 2
Console.Write("Введите трехзначное число(массив): ");
int num_3 = int.Parse(Console.ReadLine()!);
int[] avarage_array = new int[3]; // создание массива
int set = 0; // счетчик
if (num_3 >= 100)
{
    Console.Write("[ ");
    while (num_3 != 0)
    {
        avarage_array[set] = num_3 % 10; // заносим первое число в массив(последняя цифра введенного числа)
        num_3 = num_3 / 10; // удаляем эту цифру с числа,чтобы в конечном итоге число удалилось полностью,чтобы цикл прекратился
        Console.Write(avarage_array[set] + " "); // выводим числа в массиве
        set++;
    }
    Console.WriteLine(" ]");
}
else
{
    Console.Write("Неверные данные!");
}
    




                                                                                        // функции(void)
void results2(int num) // void - инициализация функции,далее идет присвоение ей имени,далее в скобочках указываются параметры,или же локальные переменные функции,() - в скобочках пишутся те значения которые нужны для работы функции,если функция просто что-то показывает в терминал мы пишем void(),если же нет мы можем записать так int name()
{
    if (num % 7 == 0 && num % 23 == 0) // оператор '&&' означает 'and'
    {
        Console.WriteLine("Введенное вами число делится и на 23 и на 7");
    }
    else
    {
        Console.WriteLine("Введенное вами число не делится,либо на 7,либо на 23");
    }
}
Console.Write("Введите число которое хотите проверить на деление на 7 и 23(функция): ");
int output = int.Parse(Console.ReadLine()!); // ввод значений 
results2(output); // далее передача введенных значений в функцию,в нашем случае,int num,будет замененно переменной output


// пример еще одной задачи с использованием функции(void),по нахождению точек лежащих на плоскости
void x_y(int x,int y) // у функции два параметра,это означает,что мы будем должны при ее вызове передать в нее тоже два параметра
{
    if (x == 0 || y == 0) // || - означает или (два поплайна)
    {
        Console.WriteLine("x = 0,y = 0"); // если x или y равен - выводим следующую надпись,эквивалент нулевой четверти на плоскости
    }
    else if (x > 0 && y > 0) // else if - означает тоже самое,что и 'elif'  в питоне
    {
        Console.WriteLine("1 четверть"); // первая четверть - расположение точки верхний правый угол на плоскости
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2 четверть"); // вторая четверть - расположение верхний левый угол на плоскости
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3 четверть"); // третья четверть - расположение левый нижний угол на плоскости
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4 четверть"); // четвертая четверть - расположение правый нижний угол на плоскости
    }
}
Console.Write("Введите x: ");
int main = int.Parse(Console.ReadLine()!);
Console.Write("Введите y: ");
int main2 = int.Parse(Console.ReadLine()!);
x_y(main,main2); // вызов функции и передача в нее двух параметров,при ее вызове она будет выполнять ту работу,что вложено в ее тело


// еще одна задача с использованием функции(void),на нахождение большей цифры числа в диапазоне от 10 до 99
int max_num_x(int a5) // можно так же задавать тип данных функции,как например  int max_num_x(int a5) -
{
    Console.WriteLine("случайное число: " + a5);
    if ( a5 % 10 > a5 / 10) // если остаток по делению,тоесть вторая цифра в числе(a5 % 10) больше деления числа(a5 / 10) тоесть первая цифра,то мы выводим одно из двух
        return a5 % 10; // если в теле условия 1 строка '{}' можно не писать,если функция должна что-то возвращать обязательное условие писать return
    return a5 / 10; // return - возвращение,тоесть функция будет отдавать результат return
}
Console.WriteLine("большая цифра в случайном числе: " + max_num_x(new Random().Next(10,100))); // new Random().Next(10,100) - выдает случайное число в диапазоне от Next(10,100) - где 10 нижняя граница диапазона,а 100 верхняя(не включая 100),тоесть 99
// чтобы вывести большую цифру в числе,мы выводим результат функции в терминал,передаем в параметр,метод выдающий рандомное число в диапазоне от (10 до 99)
// return - конечный результат функции,тоесть то,что нам выдаст если мы напишем Console.Write(max_num_x())


// еще одна задача с использованием функции(void) и метода(New Random().Next()), в которой при вводе рандомного числа программа разделит все цифры в этом числе через запятую
string string_void(int num)
{
    Console.WriteLine("случайное число: " + num);
    string allstring = "";
    while (num > 0) // пока число есть
    {
        allstring = num % 10 + "," + allstring; // берем последнюю цифру в числе операцией(num % 10) и добавляем к ней запятую,поскольку переменная в которой мы это все считаем - строка,можно добавить запятую,и прибавляем предыдущий результат
        num = num / 10; // уменьшаем число на послендюю цифру каждый шаг,пока число не станет нулем
    }
    return allstring;
}
Console.WriteLine("Ответ: " + string_void(new Random().Next(1,20000000)));


// еще одна задача с использованием функции
double new_function(int a,int b,int c, int d) // инициализация функции(поскольку она возвращает результат void не нужен),передача ей параметров,тип данных функции это тип данных который будет у return
{   
    double sum3 = (a * b) + (c / d);
    return sum3; // возвращение результата
}
new_function(1,3,45,67); // вызов функции,она так же может быть вызвана для переменной(которая имеет такой же тип данных,что и функция)


// еще одна задача,где в функцию передается число(до которого нужно считать квадрат начиная с 1)
void new_function1(int num2)
{
    int i = 1;
    while (i <= num2)
    {
        Console.Write(i * i + " ");
        i++;
    }
    
}
new_function1(10);


// еще одна задача с использованием функции(void),где в параметр передается массив и надо все четные числа преобразовать в 0
void task(int[] arr) // передача массива в параметр функции
{
    if (arr.Length != 0) // проверка не пустой ли массив
    {
        for ( int i_i = 0;i_i < arr.Length;i_i++) // цикл который найдет четные числа и преобразует их в массив
        {
            if (arr[i_i] % 2 == 0)
            {
                arr[i_i] = 0;
            }
        }
    }
    else
    {
        Console.WriteLine("Массив пустой"); // если массив пустой
    }


}
void printArray(int[] arr) // создание еще одной функции для вывода результата,чтобы код читался лучше
{
    if (arr.Length != 0) // проверка не пустой ли массив
    {
        foreach(int e in arr) // цикл который пройдет все числа в массив 
        {
            Console.Write(e + " "); // вывод чисел на экран
        }
    }
    else
    {
        Console.WriteLine("Массив пустой "); // если массив пустой
    }

Console.WriteLine();
}
int[] Array = {543,65,7,6,8,78,78,78,78,79,79,7,5,46,4,543,5}; // создание массива
task(Array); // передача в аргумент функции,которая найдет все четные числа и преобразует их в 0,этот массив
printArray(Array); // вывод уже преобразованого массива в терминал
int[] arr1 = {}; // создание пустого массива для проверки
task(arr1); // проверка
printArray(arr1); // проверка


// еще одна задача с использованием функции(void),которая возведет в куб все числа в массиве,однако не изменит сам массив
void task1(int[] arr) // создание массива и передача в параметр массива
{
    if (arr.Length > 0) // проверка не пустой ли массив
    {
        for(int iz = 0;iz < arr.Length;iz++) // создание цикла,в таких случаях 'for'
        {
            double result = Math.Pow(arr[iz],3); // возведение в квадрат всех элементов массива
            Console.Write(result + " ");
        }
    }
    else
    {
        Console.WriteLine("Массив пустой"); // если массив пустой
    }
}
int[] arr6 = {3,5,4,4,5,6,5,6,7}; 
task1(arr6); // запуск функции


// еще одна задача с использованием функции(void),где пользователь вводит длину массива и он заполнятся случайными числами типа 'int' 
void task3(int[] arr) // создание массива и передача в параметр массива
{   
    if (arr.Length > 0) // проверка не пустой ли массив
    {
        for(int i = 0;i < arr.Length;i++) // создание цикла,в таких случаях 'for'
        {
            arr[i] = arr[i] * arr[i]; // возведение в квадрат всех элементов массива
        }
    }
    else
    {
        Console.WriteLine("Массив пустой"); // если массив пустой
    }
}


void PrintVoid(int[] arr) // создание функции,которая выведет массив на экран
{

    {
        foreach(int e in arr)
        {
            Console.Write(e + " "); // цикл который выведет каждый элемент в массиве
        }
    }

}


Console.Write("Введите сколько чисел будет в массива и они заполнятся рандомными: ");
int count4 = int.Parse(Console.ReadLine()!); // задание длины массива
Random rnd1 = new(); // создание переменной которая будет генерировать случайные числа
int[] new_massive1 = new int[count4]; // создание массива и передача туда длины которую введете пользователь
int ij = 0; // счетчик
Console.Write("Ваш массив:" + "[ ");
while ( ij < count4) // пока счетчик не станет равным длине которую ввел пользователь
{
    new_massive1[ij] = rnd1.Next(1,15); // каждый круг будем вносить случайное число в массив,в индекс 'i'
    Console.Write(new_massive1[ij] + " "); // вывод случайных чисел которые сгенерировались
    ij++; // увеличение счетчика на 1
}
Console.WriteLine("]");
Console.Write("Ответ: ");
    
task3(new_massive1); // функция возведения в квадрат всех случайных чисел в массиве
PrintVoid(new_massive1); // вывод возведенных элементов массива


// еще одна задача с использованием функции (void),где пользователь вводит с терминала длину и значения массива,далее они возводятся в квадрат и выводятся
void ez_massive(int[] arr)
{
    if (arr.Length != 0) // проверка не пустой ли массив
    {
        for(int i = 0;i < arr.Length;i++)
        {
            arr[i] = arr[i] * arr[i]; // возведение в квадрат элементов,что ввел пользователь
        }
    }
    else
    {
        Console.WriteLine("Массив пустой"); // если массив пустой
    }
}


void input_massive(int[] arr) // функция вывода на экран
{
    {
        foreach (int e in arr)
        {
            Console.Write(e + " "); // цикл который выведет результат
        }
    }

}


// еще одна задача с испоьзованием функции,где пользователь вводит от какого до какого диапазона нужно найти числа в массиве(которые генерируются случайно)
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Введите с какого числа начинается диапазон чисел которые вы хотите просмотреть в массиве: ");
int range = int.Parse(Console.ReadLine()!);
Console.Write("Введите число на котором диапазон заканчивается: ");
int range2 = int.Parse(Console.ReadLine()!);


int[] PrintArray(int size)
{
    int[] array = new int[size];
    Random rnd = new();
    for (int i = 0;i < size;i++)
    {
        array[i] = rnd.Next(20,100);
        Console.Write(array[i] + " ");
    }
    return array;
}


int[] arr(int[] arr,int size,int from,int to)
{
    Console.WriteLine();
    Console.Write("Ваш овтет: ");
    int[] new_arr = new int[size];
    for(int i1 = 0;i1 < size;i1++)
    {
        if (arr[i1] <= from && arr[i1] >= to)
        {
            new_arr[i1] = arr[i1];
            Console.Write(arr[i1]);
        }
    }
    return new_arr;
} 

PrintArray(size);
arr(PrintArray(size),size,range,range2);


// еще одна задача с использованием функции,где дается случайное число и нужно занести все цифры этого числа в массив,первый индекс должен быть последней цифрой числа
Console.Write("Введите начальную цифру диапазона(целое число): ");
int input = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечную цифру диапазона(целое число): ");
int input2 = int.Parse(Console.ReadLine()!);


int rnum = new Random().Next(input,input2);
Console.WriteLine(rnum);
int count11 = 0;



int[] int_arr(int rnum,int len)
{
    int[] arr = new int[len];
    for(int i = 0;rnum > 0;i++)
    {
        arr[i] = rnum % 10;
        Console.Write(arr[i] + " ");
        rnum = rnum / 10;
    }
    return arr;
}

void num_len(int rnum)
{
    for ( ;rnum > 0;count11++)
    {
        rnum = rnum / 10;
        
    }
}
num_len(rnum);
int_arr(rnum,count11);


// еще одна задача с использованием функций,где человек может ввести параметры для поиска числа в массиве(деление нацело и последняя цифра числа),и оно найдется в массиве
Console.Write("Введите размер массива: ");
int sizez = int.Parse(Console.ReadLine()!);
Console.Write("Введите на какое число должно делится число в массиве нацело,чтобы найти его: ");
int del = int.Parse(Console.ReadLine()!);
Console.Write("Введите на какую цифру оно должно заканчиватся,чтобы найти его:");
int end = int.Parse(Console.ReadLine()!);
Random rnd4 = new();


int[] random_function(int size,int del,int end)
{
    int[] array = new int[size];
    for(int i = 0;i < size;i++)
    {
        array[i] = rnd4.Next(1,10000);
        Console.Write(array[i] + " ");
        
        if (array[i] % del == 0 && array[i] % 10 == end)
        {
            Console.Write("Ответ: " + array[i] + " ");
        }
    }
    return array;

}
random_function(sizez,del,end);


// еще одна задача с использованием функции,где пользователь вводит длину массив,после чего все числа в этом массиве преобразуются в строку
Console.Write("Введите размер массива(максимум 8): ");
int sizee = int.Parse(Console.ReadLine()!);
Random rnd11 = new();


string random_functionn(int size)
{
    int[] array = new int[size];
    for(int i = 0;i < size;i++)
    {
        array[i] = rnd11.Next(1,5);
        Console.Write(array[i] + " ");
    }
    string a = "";
    for(int i = 0;i < size;i++)
    {
        a += array[i];
    }   
    Console.WriteLine();
    Console.WriteLine(a);
    return a;

}
random_functionn(sizee);



                                                                                        //АЛГОРИТМЫ
/*
1. Константные
2. Логарефмические
3. Линейные
4. Линейно-логарефмические
5. Квадратные
6. Кубические
*/
                                                                                