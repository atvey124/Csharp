// типы данных в c#
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
int[] new_arr1 = new int[2];                                                                         
Console.WriteLine(i); // данный метод позволяет вывести что-либо в терминал по вертикале
Console.Write(i); // данный метод позволяет вывести что либо в терминал по горизонтали
Console.Write(' '); // так же в данный метод можно вывести такой тип данных как char,можно вывести любой тип данных
Convert.ToInt32(Math.Floor(i)); // метод Math.Floor - округляет в меньшую сторону число типа double,в скобочках метода указывается само число либо же переменная,перед этим число нужно конвертировать в тип данных 'int'
Console.WriteLine(string.Join("ваш массив: " + " ",new_arr1)); // string.Join() - вывод каждого элемента массива
// ("\t") - метод табуляции,в выводе каких либо значений в терминал


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
    



                                                                                        // двумерные массивы


// базовая задача на заполнение двумерного массива рандомными числами

// двумерный массив хранится в памяти в виде одномерного массива,элементы идут последовательно друг за другом,не пропуская ячеек памяти,тоесть строка 2 пойдет сразу за строкой 1


///////////////////////////////////////////////////////////////////////////////////////
int[,] table = new int[3,5]; // объявление двухмерного массива выглядит следующим образом,где int[,] - указывает что массив двумерный, table - имя, new int[3,5] - означает,что в этом массиве будет использовано три столбца(три одномерных массива), и в этих одномерных массивах будет по 5 элементов
Random rndd = new(); 
for (int ii  = 0;ii < table.GetLength(0);ii++) //создаем цикл который будет обращаться,к строкам внутри двумерного массива(строки - это количество одномерных массивов внутри двумерного,столбцы - это элементы внутри одномерного массива) table.GetLength(0) - позволяет узнать количество строк в двумерном массиве,туда передается имя массива(table),затем вызывается метод .GetLength(0), параметр 0,означает,что мы как раз таки хотим запросить количество строк 
{
    
    for( int j = 0;j < table.GetLength(1);j++) // создаем цикл,который будет обращаться конкретно к элементам внутри первого столбца(тоесть внутри первого одномерного массива)
    {
        
        table[ii,j] = rndd.Next(1,100); // в параметрах вызова двумерного массива указывается строка и столбец(в нашем случае строка - ii,столбец - j),далее мы передаем в столбец рандомные числа(увеличивая j на 1(счетчик)),пока не достигнем конца столбца,далее переходим на следующий столбец(увеличивая ii на 1)
        Console.Write($" {table[ii,j]} ");

    }
    Console.WriteLine($"Строка {ii}"); // номер строки,так же как и индекс,начинается с 0
}


//////////////////////////////////////////////////////////////////////////////////////
// заполнение двумерного массива рандомными числами,а после вывод на экран этого двумерного массива(напоминаю,что функция которая возвращает что-либо,не должна содержать вывод на экран,для этого используется другая функция)
int[,] random_matrix(int table,int table1)
{
    Random rnd = new();
    int[,] matrix = new int[table,table1]; // создание двумерного массива и передача туда параметров,что введет пользователь(количество строк и столбцов)
    for(int i = 0;i < matrix.GetLength(0);i++) // цикл который отвечает за строки
    {
        for(int j = 0;j < matrix.GetLength(1);j++) // цикл который отвечает за столбцы
        {
            matrix[i,j] = rnd.Next(1,101);
        }
        
    }
    return matrix;
}
void print_matrix(int[,] matrix)
{
    for(int i = 0;i < matrix.GetLength(0);i++)
    {
        for(int j = 0;j < matrix.GetLength(1);j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine($"Столбец № {i}");
    }
}
Console.Write("Введите сколько строк будет в двумерном массиве: ");
int table_one = int.Parse(Console.ReadLine()!);
Console.Write("Введите сколько столбцов будет в двумерном массиве: ");
int table1 = int.Parse(Console.ReadLine()!);



// еще одна задача,где нужно обозначить числа в двумерном массиве,сумма цифр которых четна,ключевым словом - intresting.ПОЗЖЕ НУЖНО ОПТИМИЗИРОВАТЬ АЛГОРИТМ
int[,] random1_matrix(int table,int table1)
{
    Random rnd = new();
    int[,] matrix = new int[table,table1]; // создание двумерного массива и передача туда параметров,что введет пользователь(количество строк и столбцов)
    for(int i = 0;i < matrix.GetLength(0);i++) // цикл который отвечает за строки
    {
        for(int j = 0;j < matrix.GetLength(1);j++) // цикл который отвечает за столбцы
        {
            matrix[i,j] = rnd.Next(1,100);
        }
        
    }
    
    return matrix;
}

int[,] if_matrix(int[,] matrix)
{
    for(int i = 0;i < matrix.GetLength(0);i++)
    {
        for(int j = 0;j < matrix.GetLength(1);j++)
        {
            int sum = 0; // переменная которая будет считать сумму цифр в числе
            int current_index = matrix[i,j]; // текущее расматриваемое число,в строке [i]
            for (int k = 0;current_index != 0;k++) // цикл который будет считать сумму всех цифр числа
            {
                sum = sum + current_index % 10;
                current_index = current_index / 10;

            }
            Console.Write(sum + ", ");
            if (sum % 2 == 0) // если сумма цифр четная
            {
                Console.Write("- Intresting," + " ");
            }
            sum = 0; // обнуление счетчика и повторный круг         
            
        }
    }
    return matrix;
}

void print_matrix1(int[,] matrix) // функция вывода
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

Console.Write("Введите сколько строк будет в двумерном массиве: ");
int table_one1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите сколько столбцов будет в двумерном массиве: ");
int table11 = int.Parse(Console.ReadLine()!);



int[,] matrix1 = random1_matrix(table_one1,table11);

print_matrix1(matrix1);

Console.WriteLine();

if_matrix(matrix1);


int[,] matrix = random_matrix(table_one,table1); // создание переменной и передача туда результат функции random_matrix
print_matrix(matrix); // вызов функции печати и передача туда в параметр переменную,содержащую результат функции random_matrix


// еще одна задача,где нужно возвести в квадрат элементы двумерного массива,чей индекс четный

int[,] random11_matrix(int table,int table1)
{
    Random rnd = new();
    int[,] matrix = new int[table,table1]; // создание двумерного массива и передача туда параметров,что введет пользователь(количество строк и столбцов)
    for(int i = 0;i < matrix.GetLength(0);i++) // цикл который отвечает за строки
    {
        for(int j = 0;j < matrix.GetLength(1);j++) // цикл который отвечает за столбцы
        {
            matrix[i,j] = rnd.Next(1,100);
        }
        
    }
    
    return matrix;
}

void iseven(int[,] matrix)
{
    for(int i = 0;i < matrix.GetLength(0);i++)
    {
        for(int j = 0;j < matrix.GetLength(1);j++)
        {
            if(i % 2 == 0) // проверка на четность первого индекса(индекса строки)
            {
                if (j % 2 == 0) // проверка на четность второго индекса(индекса столбца)
                    Console.Write($"Элемент {matrix[i,j]}, имеет четный индекс ");
                    Console.WriteLine($"Его квадрат {Math.Pow(matrix[i,j],2)}"); // если оба индекса четны,возводим в квадрат элемент под этими индексами
            }

        }
    }
}

void print_matrix11(int[,] matrix) 
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





Console.Write("Введите сколько строк будет в двумерном массиве: ");
int table_one11 = int.Parse(Console.ReadLine()!);
Console.Write("Введите сколько столбцов будет в двумерном массиве: ");
int table111 = int.Parse(Console.ReadLine()!);




int[,] matrix3 = random11_matrix(table_one11,table111);

print_matrix11(matrix3);

iseven(matrix3);


// задача на нахождение суммы элементов на главной диагонали,главная диагональ это диагональ с начала двумерного массива,которая идет по диагонали до конца массива

int[,] random1_matrix1(int table,int table1)
{
    Random rnd = new();
    int[,] matrix = new int[table,table1]; // создание двумерного массива и передача туда параметров,что введет пользователь(количество строк и столбцов)
    for(int i = 0;i < matrix.GetLength(0);i++) // цикл который отвечает за строки
    {
        for(int j = 0;j < matrix.GetLength(1);j++) // цикл который отвечает за столбцы
        {
            matrix[i,j] = rnd.Next(1,100);
        }
        
    }
    
    return matrix;
}

void IsSum(int[,] matrix)
{
    int sum = 0;
    
    for(int i = 0;i < matrix.GetLength(0);i++) // цикл отвечающий за строку
    {
        int j = i; // счетчик который будет равен строке,тоесть если мы на нулевой строке,то и столбец будет нулевым,если на первой,то и столбец будет первым,таким образом проводим диагональ до конца массива
        sum = sum + matrix[i,j];

    }
    Console.WriteLine(sum);
}
    


void print_matrix12(int[,] matrix) 
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





Console.Write("Введите сколько строк будет в двумерном массиве: ");
int table_one111 = int.Parse(Console.ReadLine()!);
Console.Write("Введите сколько столбцов будет в двумерном массиве: ");
int table1111 = int.Parse(Console.ReadLine()!);




int[,] matrix11 = random1_matrix1(table_one111,table1111);

print_matrix12(matrix11);

IsSum(matrix11);


// задача где среднее арефметическое каждой строки двумерного массива записывается в одномерный,а после считается среднее арфеметическое всех записанных строк

int[,] random1_matrix3(int table,int table1)
{
    Random rnd = new();
    int[,] matrix = new int[table,table1]; // создание двумерного массива и передача туда параметров,что введет пользователь(количество строк и столбцов)
    for(int i = 0;i < matrix.GetLength(0);i++) // цикл который отвечает за строки
    {
        for(int j = 0;j < matrix.GetLength(1);j++) // цикл который отвечает за столбцы
        {
            matrix[i,j] = rnd.Next(1,100);
        }
        
    }
    
    return matrix;
}

double[] average(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int size1 = matrix.GetLength(1);
    double[] sum = new double[size];
    for(int i = 0;i < size;i++) 
    {
        double arrefmetic_sum = 0;
        for (int j = 0;j < size1;j++)
        {
            arrefmetic_sum = arrefmetic_sum + matrix[i,j];
        }
        sum[i] = arrefmetic_sum / size1;

    }
    return sum;
}
    
void print_matrix13(int[,] matrix) 
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

void print_matrix2(double[] sum)
{
    Console.Write("[");
    for(int i = 0;i < sum.Length;i++)
    {
        Console.Write(sum[i] + " ");
    }
    Console.WriteLine("] - каждый элемент равен среднему арефметическому,каждого столбца двумерного массива");
}

void average1 (double[] arr_sum)
{
    double sum1 = 0;
    for(int i = 0;i < arr_sum.Length;i++)
    {
        sum1 += arr_sum[i];
    }
    sum1 = sum1 / arr_sum.Length;
    Console.WriteLine($"Среднее арфеметическое массива из средних арефметических строк двумерного массива равно: {sum1}");
}


Console.Write("Введите сколько строк будет в двумерном массиве: ");
int table_one13 = int.Parse(Console.ReadLine()!);
Console.Write("Введите сколько столбцов будет в двумерном массиве: ");
int table13 = int.Parse(Console.ReadLine()!);




int[,] matrix23 = random1_matrix3(table_one13,table13);

print_matrix13(matrix23);

double[] arr_sum = average(matrix23);

print_matrix2(arr_sum);
Console.WriteLine();
average1(arr_sum);


// функция которая найдет нужный элемент который попросил пользователь в двумерном массиве,так же можно указать сколько раз это нужно повторить,ответ занесется в одномерный массив

Random str111 = new();
Random str1111 = new();
int str = str111.Next(1,11); // рандомное количество строк
int str1 = str1111.Next(1,11); // рандомное количество столбцов


int[,] random1_matrix11(int str,int str1)
{
    Random rnd = new();
    int[,] matrix = new int[str,str1 + 1]; // создание двумерного массива и передача туда параметров,что введет пользователь(количество строк и столбцов)
    for(int i = 0;i < matrix.GetLength(0);i++) // цикл который отвечает за строки
    {
        for(int j = 0;j < matrix.GetLength(1);j++) // цикл который отвечает за столбцы
        {
            matrix[i,j] = rnd.Next(1,100);
        }
        
    }
    
    return matrix;
}

int[] IsElement(int[,] matrix) // функция которая найдет нужный элемент который попросил пользователь в двумерном массиве,так же можно указать сколько раз это нужно повторить,ответ занесется в одномерный массив
{
    Console.Write("Введите сколько элементов нужно найти: ");
    int repeat = int.Parse(Console.ReadLine()!);
    int[] repeat_arr = new int[repeat]; // длина массив такая которую ввел пользователь
    for(int i = 0;i < repeat_arr.Length;i++)
    {

    

        Console.Write("Введите на какой строке вы хотите найти элемент: ");

        int str_input = int.Parse(Console.ReadLine()!);

        Console.Write("Введите индекс какого элемента вы хотите найти: ");

        int column_input = int.Parse(Console.ReadLine()!);
        try // если такой индекс есть то он заносится в массив
        {
            Console.WriteLine($"Элемент {matrix[str_input,column_input]}");
            repeat_arr[i] = matrix[str_input,column_input];
            
        } 
        catch // если нет
        {
            Console.WriteLine($"Индекс за пределом массива {str_input} {column_input}");
            Console.WriteLine($"Количество строк: {str + 1}, количество столбцов: {str + 1}");
            i--;
        }
        
    }
    return repeat_arr;

}
    

    
void print_matrix122(int[,] matrix) // функция вывода двумерного массива
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
 
int[,] matrix12 = random1_matrix11(str,str1);

print_matrix122(matrix12);

int[] IsElement1 = IsElement(matrix12); // 
Console.WriteLine($"Получившейся массив: [{string.Join(", ",IsElement1)}]");


// базовая задача на нахождение минимальной строки,с использованием вспомогательного массива

int[,] RandomGenerator(int size,int size1) // создание рандомного массива
{
    Random rnd = new();
    int[,] res = new int[size,size1];
    for(int i = 0;i < res.GetLength(0);i++)
    {
        for(int j = 0;j < res.GetLength(1);j++)
            res[i,j] = rnd.Next(-100,100);
    }
    return res;
}


void PrintFunction(int[,] quicksort) // вывод массива
{
    for(int i = 0;i < quicksort.GetLength(0);i++)
    {
        for(int j = 0;j < quicksort.GetLength(1);j++)
        {
            Console.Write(quicksort[i,j] + " ");
        }
        Console.WriteLine();
        
    }
}

/*
bool TestFunction(int[] quicksort)
{
    for(int i = 0;i < quicksort.Length - 1;i++)
    {
        
        if (quicksort[i] > quicksort[i + 1])
        {
            return false;
        }
        
    }
    return true;
}
*/

int[] findminstr (int[,] quicksort)
{
    int[] sum_of_str = new int[quicksort.GetLength(0)]; // массив в котором будет хранится сумма всех строк
    int sum; // сумма строки 
    for(int i = 0;i < quicksort.GetLength(0);i++)
    {
        sum = 0; // обнуляем сумму
        for(int j = 0;j < quicksort.GetLength(1);j++)
        {
            sum += quicksort[i,j]; // считаем сумму строки
             
        }
        sum_of_str[i] = sum; // далее записываем эту сумму в спомогательный массив,на индекс той строки которую мы сейчас прошли 

    }
    return sum_of_str;
}


void find_min_str (int[] min_str) // а теперь просто нахождение минимальной суммы в нашем вспомогательном массиве
{
    int min = min_str[0];
    int index = 0; // индекс элементов совпадает с индексом строк в двумерном массиве,поэтому просто записываем индекс в отдельную переменную
    for(int i = 0;i < min_str.Length;i++)
    {
        if ( min_str[i] < min)
        {
            min = min_str[i];
            index = i;
        }
    }
    Console.WriteLine($"Сумма элементов в минимальной строке равна: {min} ");

    Console.WriteLine($"Индекс строки равен: {index}");
}


Console.WriteLine("Введите количество строк двумерного массива");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов двумерного массива");

int size1 = int.Parse(Console.ReadLine()!);

int[,] quicksort = RandomGenerator(size,size1); 

PrintFunction(quicksort);

int[] min_str = findminstr(quicksort);

find_min_str(min_str);


/////////////////////////////////////////////////////////////////////////////////
int[,] table3 ={
    {43 ,65 ,786 ,5454 ,564},
    {54,675,76,53,65}
}; // так же двумерный массив можно создавать таким образом

// ВАЖНОЕ НАПОМИНАНИЕ

// двумерный массив должен содержать во всех строках,одинаковое количество столбцов
// тоесть во одномерных массивах,внутри двумерного,должно быть равное количество элементов


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
1. Константные - алгоритмы которые идут своим ходом и не зависят от числа n,другими словами нет привязки к введенному значению
2. Логарефмические - разность между соседними числами a - b,другими словами бинарный поиск
3. Линейные - где число идет линейно 1+2+3+4+5...n,сложность O() - привязана к введенному значению
4. Линейно-логарефмические - быстрая сортировка другими словами(рекурсия)
5. Квадратные - другими словами пузырьковая сортировка,сортировка выбором,сортировка вставками
6. Кубические - трехмерные массивы
Сложность алгоритма - количество действий для получения конечного результата,обозначается - O
*/
// сложность алгоритма,подругому O() - это количество действий которые необходимо выполнить для получения результата




                                                                                    //линейные алгоритмы
Random ns = new();
int random = ns.Next(1,20);
int res = 0;
for ( int i300 = 0;i300 < random;i300++) // алгоритм линейный поскольку,чтобы его выполнить программа выполнит 'random' действий в данном случае,где рандом число повторений,1+2+3+4+5....random
{
    res++; // сложность алгоритма можно обозначить как O(random)
} 


int sum_arr = 0;
Console.WriteLine("выберите длину массива");
int key_size = int.Parse(Console.ReadLine()!);
int[] new_arr = new int[key_size];
Console.Write("Заполните массив целыми числами: ");
for (int iz = 0;iz < key_size;iz++) // складывает сумму всех чисел в массиве введенных пользователем
{
    new_arr[iz] = sum_arr + new_arr[iz]; // алгоритм линейный поскольку,программа выполнит O(key_size) повторений для того,чтобы узнать результат
}

// так же можно провести быструю сортировку - O(n * log(n)),где n - количество элементов в массиве,и записать этот алгоритм как sum_arr = (('первый элемент массива ' + 'последний ' / 2) * 'размер массива') - таким образом сложность будет равна O(1),однако это не всегда быстрее
 
//  в данном примере,показан наиболее оптимизированный вариант решения



                                                                                    //константые алгоритмы
double random1 = int.Parse(Console.ReadLine()!);
double rez = (1 + random1) / 2 * random1; // число n в нашем случае - random1,задача находит сумму чисел от 1 до random1,сложность O(1),где (1) - количество действий для получения результата,так же нет привязки к введенному значению
Console.WriteLine(rez);         




                                                                                    //логарефмические алгоритмы

// АЛГОРИТМ БИНАРНОГО ПОИСКА




//примером может быть простая игра - угадай число,где мы путем деления высшей границы диапазона случайно загаданного числа,на два,узнаем больше либо меньше случайное число

//угадай число от 1 до 100,100 / 2 = 50,50 > случайного числа?если да => 75 > случайного числа?,сложность алгоритма O(log2(n - количество попыток))

//если же к примеру загаданно число от 1 до 1000,то по формуле сложности алгоритма мы можем найти сколько попыток потребуется => log2(1000) ~ 10 попыток

//к примеру нам данн случайный массив и нам необходимо выполнить алгоритм бинарного поиска

//выглядеть это будет следующим образом O(n * log2(n)) - рекурсивный подход,снизу приведен пример

// дан массив [65,767,87,534,-10,54,7687,653]




// АЛГОРИТМ БЫСТРОГО ПОИСКА(РЕКУРСИИ)

// 1. в массиве выбирается опорный элемент(чаще всего берется первый элемент)

// 2.создается 2 массива,первый массив содержит элементы меньше опорного

// 3. второй массив содержит элементы больше либо равные опорному

// 4. В нашем случае это выглядит так [-10,54] + [65] + [767,87,534,7687,653] -- и так результат рекурсии,массив [-10,54,65,87,534,653,767,7687] - еще раз напоминаю,что рекурсия идет снизу вверх(c 9 номера по 4),все что правее ставится в правую часть массива,все,что ливее в левую

//                                    первый массив + сам опорный элемент + второй массив

// 5. Далее тот же метод создается два массива,только опорным будет уже [-10] -- тут,так [-10,87,534,653,767,7687],[767] стоит в этом месте,поскольку все правые части уже отсартированы

//                                                                      [] + [-10] + [767,87,534,7687,653]

// 6. Снова повторяем тот же принцип,опорным элементом будет - [767] -- тут уже так [87,534,653,767,7687]

//                                                             [87,534,653] + [767] + [7687]

// 7. Снова повторяем опорный - [87] -- тут,так [87,534,653,7687]

//                              [] + [87] + [534,653,7687]

// 8. Снова,опорный - [534] -- тут массив выглядит уже так [534,653,7687]

//                    [] + [534] + [653,7687]

// 9. Снова,опорный - [653] -- рекурсия заносит в массив данные те что в правом массиве,заносятся в правую часть,те что в левом в левую,тоесть наш новый массив выглядит следующим образом [653,7687]

//                    [] + [653] + [7687]

// 10.Далее рекурсия как бы идет снизу вверх,с 9 номера по 4
                                                                                    //квадратные алгоритмы


// СОРТИРОВКА ВЫБОРОМ

// допустим у нас есть массив [9,876,65,5434,654,765,35,-10,-100,1]
// мы сначала находим минимальное значение(как сделать это,мы уже знаем)
// далее мы меняем его с первым элементом массива
// и получаем массив [-100,876,65,5434,654,765,35,-10, 9,1]
// далее мы снова находим минимальное число в массиве,но уже в диапазоне [876,65,5434,654,765,35,-10, 9,1] -  минимальным будет (-10)
// и мы снова меняем минимальное число со вторым элементом в массиве(индексом 1)
// и получаем массив [-100,-10,65,5434,654,765,35,976, 9,1]
// таким образом диапазон каждый раз уменьшается и минимальное число меняется с текущим индексом
// если продолжить мы получим полностью отсортированный массив [-100,-10,1,9,35,65,654,765,876,5434]
// когда таким путем мы дойдем до последнего элемента,искать минимальное уже не нужно, и менять его местами тоже не нужно,оно будет максимальным в массиве
// если произойдет такая ситуация,допустим,что текущий индекс и так является мнимальным,менять его местами не нужно,просто идем к следующему индексу


// базовая сортировка выбором
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
            if ( arrr[j] < arrr[index_min]) // после прохода цикла найдется минимальный элемент и поменяется местами с arr[index_min]
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
Console.WriteLine($"Ответ: {string.Join(", ", arr_function(arrr))}"); // внутри параметра string.Join вызывается функция которая возвращает отсортированный массив,именно поэтому мы передаем ее сюда
// Сложность данного алгоритма O(n ^ 2)


// простой калькулятор
int num = int.Parse(Console.ReadLine()!); // ввод числа
for(int ii1 = 1;ii1 <= num;ii1++) // цикл который будет переключать вертикаль,тоесть переход к другой строке
{
    for(int j = 1;j <= num;j++) // который выполнится только после выполнения этого цикла,в котором считается 
    {
        Console.Write(ii1 * j); // цикл который заносит умножения по горизонтали
        Console.Write("\t");
    }
    Console.WriteLine(); // сложность данного алгоритма будет O(n^2) - где n - число которое ввел пользователь(число повторений)
    
}// О(n ^ 2) - сложность алгоритма


//ПУЗЫРЬКОВАЯ СОРТИРОВКА

// представим у нас есть массив [43,65,23,8798,6543]
// мы берем первым два элемента и если первый элемент больше,то мы меняем их местами[43,65], получается [43,65,76,8798,6543] - если первый элемент меньше оставляем так как есть
// и так повторяем уже со следующими двумя элементами[65,23] - тут первый элемент больше,значит меняем местами,получается [43,23,65,8798,6543]
// повторяем еще раз[65,8798],получается - [43,23,65,8798,6543]
// повторяем[8798,6543],получается - [43,23,65,6543,8798]
// и так когда мы дошли до конца массива,мы берем и делаем это еще раз [43,23],получается - [23,43,65,6543,8798]

// напомню,что если первый элемент меньше,мы ничего не делаем,если больше меняем местами


// так это выглядит в коде
// сложность O(n - 1)^2 = O(n^2 - 2n + 1)


Console.Write("Введите длину массива: ");
try
{
    int size12 = int.Parse(Console.ReadLine()!);
    Random rnd_num12 = new();
    int[] arrr12 = new int[size12];
    for (int i1000 = 0;i1 < size12;i1000++)
    {
        arrr[i1000] = rnd_num12.Next(-30,100);
    }



    bool test12 (int[] arrr) // базовый тест,который будет выводить true - если массив отсортирован и false если нет
    {
        for(int i = 0;i < arrr.Length - 1;i++)
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
                if (arrr[j] > arrr[j + 1]) // если текещее число меньше следующего
                {
                    arrr[j] = arrr[j + 1]; // меняем их местами
                    arrr[j + 1] = temp1;

                }
            }

        }
        return arrr;
    }
    Console.WriteLine($"начальный массив: {string.Join(",", arrr12)}");
    Console.WriteLine(test12(arrr12));
    Console.WriteLine($"готовый массив: {string.Join(",", bubble_function(arrr12))}");
    Console.WriteLine(test12(arrr12));
    
}
catch
{
    Console.WriteLine("Вы ввели не тот тип данных,требуется 'int' ");
}




                                                                                    //линейно-логарефмические алгоритмы
//БЫСТРАЯ СОРТИРОВКА
Console.Write("Введите длину массива: ");
try // то что в блоке try - выполняется пока не вылезет ошибка
{
    T[] Concat<T>(params T[][] arrays) // объединение всех массивов в один
    {
        var result = new T[arrays.Sum(a => a.Length)]; // готовый массив
        int offset = 0;
        foreach(T[] arrr in arrays)
        {
            arrr.CopyTo(result,offset); // массив будет соединен с другим начиная с offset,соединенный массив - result
            offset += arrr.Length; // добавление количество элементов которые мы внесли в готовый массив в переменную offset,изначально готовый массив пустой
        }
        return result;
    }

    int size12 = int.Parse(Console.ReadLine()!); // создание рандомного массива на количество элементов которое ввел пользователь
    Random rnd_num12 = new();
    int[] arrr = new int[size12];
    for (int i1000 = 0;i1000 < size12;i1000++)
    {
        arrr[i1000] = rnd_num12.Next(-30,100);
    }



    bool test12 (int[] arrr) // базовый тест
    {
        for(int i = 0;i < arrr.Length - 1;i++)
        {
            if ( arrr[i] > arrr[i + 1]) 
                return false;
        }
        return true;
    }


    int[] quick_sort(int[] arrr)
    {
        if (arrr.Length < 2)
        {
            return arrr; // это базовый случай,тоесть массив отсортирован
        }
        else
        {
            int reference = arrr[0]; // опорный элемент(всегда первый элемент массива)
            int coun = 0; // счетчик сколько элементов  в массиве меньше либо больше либо равны опорному(универсальный счетчик)
            foreach (int e in arrr) // подсчет сколько элементов в массиве меньше опорного
            {   
                if (e < reference)
                {
                    coun++;
                }
            }
            int[] less = new int[coun]; // создание массива для чисел которые меньше опорного,передача туда значения 'coun' - количество элементов меньше опорного
            int j = 0; // индекс который будет заносить элементы из основного массива в массив содержащий элементы(большие,равные,меньшие) опорному
            for (int i = 0;i < arrr.Length;i++)
            {
                if (arrr[i] < reference)
                {
                    less[j] = arrr[i];
                    j++;
                }
            }
            coun = 0;
            foreach(int el in arrr) // проверка сколько чисел в основном массиве больше опорного
            {
                if (el > reference)
                {
                    coun++;
                }
            }
            int[] greater = new int[coun];
            j = 0;
            for (int i = 0;i < arrr.Length;i++) // занесение элементов из основного массива в массив содержащий элементы больше опорного
            {
                if (arrr[i] > reference)
                {
                    greater[j] = arrr[i];
                    j++;
                }
            }
            coun = 0;
            foreach (int e in arrr) // проверка сколько элементов в массиве равны опорному
            {
                if (e == reference)
                {
                    coun++;
                }
            }
            int[] reference_arr = new int[coun]; // занесение элементов из основного массива в массив содержащий элементы равные массиву
            for (int i = 0;i < coun;i++)
            {
                reference_arr[i] = reference;
            }
            int[] result = Concat(quick_sort(less), reference_arr, quick_sort(greater)); // объединение всех массивов в один,надо почитать!
            return result;
        }
    }
    Console.WriteLine($"начальный массив: {string.Join(",", arrr)}");
    Console.WriteLine(test12(arrr));
    Console.WriteLine($"готовый массив: {string.Join(",", quick_sort(arrr))}");
    Console.WriteLine(test12(arrr));
    
}
catch // то что в блоке catch - выполняется после того как в 'try' вылезла ошибка
{
    Console.WriteLine("Вы ввели не тот тип данных,требуется 'int' ");
}
//сложность - O(log2(size))


// базовая сортировка подсчетом
// преимущество данной сортировки в том,что она сразу записывает все элементы массива по их порядку,минус в том,что она выделяет много избыточной памяти для этого,поскольку даже если элемента нет в массиве(допустим 4 нет в массиве),она все равно создаст для нее место,ведь она идет последовательно от большего к меньшему элементу массива(ввыделяя памяти на разницу этих элементов)

int[] RandomGenerator(int size) // создание рандомного массива
{
    Random rnd = new();
    int[] res = new int[size];
    for(int i = 0;i < res.Length;i++)
    {
        res[i] = rnd.Next(0,100);
    }
    return res;
}


void PrintFunction(int[] quicksort) // вывод массива
{
    for(int i = 0;i < quicksort.GetLength(0);i++)
    {
        Console.Write(quicksort[i] + " ");
    }
}


bool TestFunction(int[] quicksort)
{
    for(int i = 0;i < quicksort.Length - 1;i++)
    {
        
        if (quicksort[i] > quicksort[i + 1])
        {
            return false;
        }
        
    }
    return true;
}



void countingsort(int[] quicksort)
{
    int min = quicksort.Min(); // чтобы посчитать какое будет смещение нужно найти минимальный элемент

    int max = quicksort.Max(); // и разницой между минимальным и максимальным элементом и будет длина массива

    int offset = -min; // смешение нужно для того,чтобы поставить минимальный элемент на первую позицию,а все остальные сместить на столько,сколько между ними разницы,-min означает тоже самое,что и -1 * min

    int[] helparray = new int[max + offset + 1]; // чтобы уместить все элементы в спомогательном массиве,мы как раз добавляем это смещение и 1,поскольку индекс начинается с 0
    
    for(int i = 0;i < quicksort.Length;i++) // цикл который будет записывать число повторений тех или иных элементов в спомогательный массив,его длина формируется исходя из максимального числа(тоесть,он будет ставить число повторений чисел от 0 до максимального числа,к примеру 0 - повторяется 1 раз,1 - повторяется 0 раз,значит он поставит ноль) 
    {
        helparray[quicksort[i] + offset]++; // в индекс(который равен числу[i] в неотсортированном массиве) вспомогательного массива добавляется + 1,таким образом каждое последующее число ставится на свой индекс в спомогательном массиве(с учетом смещения,которое равно минимальному объекту)
    }

    int input_index = 0; // индекс на который мы будем ставить каждый последующий элемент
    for(int i = 0;i < helparray.Length;i++) // цикл который будет переходить к следующему числу которое нужно поставить
    {
        for(int j = 0;j < helparray[i];j++) // цикл который будет ставить число в отсорт.массив столько раз сколько оно повторяется
        {
            quicksort[input_index] = i - offset;  // с учетом смещения
            input_index++; // после того как число поставили на свое место,индекс добавляется
        }
    }

}


Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine()!);

int[] quicksort = RandomGenerator(size); 

PrintFunction(quicksort);
Console.WriteLine();

countingsort(quicksort);

PrintFunction(quicksort);
Console.WriteLine();

Console.Write(TestFunction(quicksort));



                                                                                    //матрицы

int[, ] matrix = new int[num,num]; // создание матрицы происходит так,где int - тип данных,[num,num] - диапазон матрицы,откуда до куда
// размерность матрицы 3 - 3 * 3.Так же размерность матрицы 5 - 5 * 5




//                                                          0   1   2
//матрица с размерностью 3 выглядит следующим образом -  0 [5] [6] [7]
//                                                       1 [6] [5] [8]
//                                                       2 [7] [8] [5]             
//                                                       элемент 5 стоит на позиции[0,0] - смежный ему элемент стоит на позиции [0,0] - смежный значит одинаковый,он всегда находится по диагонали
//                                                       элемент 6 стоит на позици [1,0] - смежный элемент [0,1]
//                                                       элемент 7 стоит на позиции [2,0] - смежный элемент [0,2]
//                                                       элемент 8 стоит на позиции [2,1] - смежный элемент [1,2]




//базовый калькулятор на матрицах
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



                                                                                    //сетевые взаимодействия
// и так разберем на примере обычной ссылки,то как она устроена
//              http://geekbrains:80/lesson/123456/index.html
//              ^           ^     ^         ^            ^
//           протокол  имя сервера порт путь к документу имя документа







//сетевой протокол
//первым идет канальный(wifi,ethernet) - он оприделяет через что физически передавать калибания(провод,роутер)
//вторвым идет сетевой(ip) - он определяет в какой именно компьютер нужно передать эти сигналы
//третьим идет транспортный(TCP,UDP) - он передает нужные байты на монитор
//четвертым идет прикладной(HTTP,HTTPS,FTP,SMTP) - он конвертирует байты в обычный стандартный текст,определяемый самим протоколом(к примеру HTTP)




                                                                                    //простые принципы создания ПО


// DRY(dont repeat tour self) - не повторяй те моменты кода которые уже были созданы(избегай дублирование одинакового кода,используй функции,чтобы предотвратить это)
// KISS(keep it simple,stupid) - не усложняй код без необходимости(не нужно усложнять если подойдет более простое решение)
// YAGNI(you aren't gonna need it) - не делай то что не потребуется(откажись от избыточной и не нужной функциональности,если пишешь код будь уверен,что он понадобится)




                                                                                    // рекурсия
// рекурсией называется - когда функция вызывает саму себя
// компоненты рекурсии - 1. основная работа(то,что будет выполнять рекурсия после ее вызова),2. рекурсивный вызов (который будет упрощать решение задачи),3.типовой случай(то когда функция достигнет наиболее легкого решения и остановится)
// после достижения базового случая начинается 'раскручивание рекурсии',последовательность возврата к местам вызова функции
// С КАЖДЫМ НОВЫМ ВЫЗОВОМ РЕКУРСИИ,ЗАДАЧА СТАНОВИТСЯ ЛЕГЧЕ

// ПЕРЕПОЛНЕНИЕ СТЕКА
// в памяти так же сохраняется места вызова функции,так же значение параметров функции при вызове - называется эта область памяти стек
// при раскручивании рекурсии,информация будет браться именно оттуда(из стека) в обратном порядке(сначала будет браться информация о первом вызове,затем о втором),тоесть в примере ниже при раскручивании рекурсии,первым значением,что мы увидим,будет - не 5,а 2.Поскольку идет она в обратном порядке
// если условие для остановки отсутствует,функция будет выполняться бесконечно(что и приведет к переполнению стека)
// чтобы этого не допустить,нужно остановить рекурсию на базовом случае,как в примере ниже

// пример

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




                                                                                    // СТРОКИ
// строка является массивом,содержащим элементы типа 'char'
// тоесть зная порядковый номер определенного элемента,мы можем к нему обратиться
//РАССМОТРИМ ПРИМЕР

string hello = "hello world";
Console.WriteLine(hello[0]); // результатом будет (h)

// элементы строки не могут быть изменены,а так же строка не может быть уменьшина либо увеличина,что не присуще массиву
//РАССМОТРИМ ПРИМЕР

hello[1] = "E"; // в таком случае вылезет ошибка,ведь мы попытались изменить строку

//так же строку можно создавать как массив типа данных 'char'

char[] ch_array = { 'h','e','l','l','o' };
string str1 = new String(ch_array); // new String - является конструктором,который создает объект,в параметр этого конструктора кладется символьный массив

//так же доступен еще и такой способ
string s = new String('a',7); // результатом будет (aaaaaaa)


//МЕТОДЫ СТРОК

//Contains - метод позволяющий определить есть ли в строке подстрока
//EndsWith - метод позволяющий определить,совпадает ли конец строки с подстрокой
//index() - метод который находит индекс первого вхождения символа или подстроки в строке
//insert - вставляет в строку подстроку
//Replace - замещает в строке символ или подстроку другим символом или подстрокой

// до этого было сказано,что строки не изменяемый тип данных,однако методы могут их менять
// точнее они просто создают новую строку в памяти и туда помещают метод и саму строку


//базовая задача на строки,где нужно отделить буквы от цифр
string GetLetters(string let)
{
    string letter = "";
    foreach(char e in let)
    {
        if (char.IsLetter(e) == true) // char.IsLetter - метод которому присущ тип данных 'char' - позволяет узнать является ли символ в строке буквой
        {
            letter = letter + e; // цикл который будет добавлять буквы в новую переменную
        }
    }
    return letter;
}

string letter = "re43345fdgfg"; // переменная являющяяся параметром функции
string str = GetLetters(letter); // создаем переменную и вызываем внутри функцию
Console.WriteLine(str);


// задача,где пользователь вводит с консоли символы и они конвертируются в строку,а затем в массив символов
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


string char_string(char[] char_arr) // функция которая будет конвертировать введеные пользователем символы в строку
{
    string str = "";
    foreach(char e in char_arr) // char e - это содержимое массива,тоесть как бы текущий индекс который мы просматриваем,однако в foreach нет индекса,он идет последовательно от начала до конца,тем не менее e - текущее содержимое
    {
        str += e;
    }
    return str;
}


void string_to_char_arr(string str_to_char) // функция которая будет конвертировать из получившейся строки обратно в массив типа 'char'
{
    for(int i = 0;i < str_to_char.Length;i++)
    {
        char_arr[i] = str_to_char[i];
    }
    Console.WriteLine($"Массив символов из строки: {string.Join(", ",char_arr)}");
}



char_generator(char_arr);

Console.WriteLine($"строка из массива символов: {char_string(char_arr)}");

string str_to_char = char_string(char_arr);

string_to_char_arr(str_to_char);



                                                                                    //ПАРАЛЛЕЛЬНОЕ ВЫЧИСЛЕНИЕ

// обычное умножение матриц,без параллельного вычисления

int[,] RandomGenerator(int size,int size1)
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


void PrintFunction(int[,] matrix)
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


int[,] equal_matrix(int[,] first_matrix,int[,] second_matrix)
{
    int[,] result = new int[first_matrix.GetLength(0),first_matrix.GetLength(1)];

    if (first_matrix.GetLength(1) != second_matrix.GetLength(0)) // проверка на то,совпадает ли количество строк в первой матрицы с количеством столбцов второй матрицы
    {
        Console.WriteLine("Данные матрицы не могут быть умножены");
        return result;
    }
    for(int i = 0;i < first_matrix.GetLength(0);i++)
    {
        for(int j = 0;j < first_matrix.GetLength(1);j++)
        {
            result[i,j] = first_matrix[i,j] * second_matrix[i,j]; // каждый элемент первой матрицы умножается на каждый элемент второй матрицы
        }
    }
    return result;
}


Console.Write("Введите количество строк для обоих матриц: ");

int size13 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов для обоих матриц: ");

int size14 = int.Parse(Console.ReadLine()!);





int[,] first_matrix = RandomGenerator(size13,size14); //  заполнение первой матрицы случайными элементами

int[,] second_matrix = RandomGenerator(size13,size14); // завполнение второй матрицы случайными элементами

PrintFunction(first_matrix); // вывод первой матрицы

Console.WriteLine();

PrintFunction(second_matrix); // вывод второй матрицы

Console.WriteLine();

int[,] result = equal_matrix(first_matrix,second_matrix); // двумерный массив который будет хранить однопоточное умножение матриц размером [N12,N12],

PrintFunction(result); // вывод результата


// вот так будет выглядеть эта же задача но уже с использованием потоков и смежного умножения матриц

const int N = 20; // размерность нашей матрицы(количество строк и столбцов)

int[,] serialMulres = new int[N,N]; // конечный результат матрицы

const int Thread = 10; // количество потоков

int[,] RandomGenerator6(int size,int size1) // создание рандомного массива
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


void PrintFunctionn(int[,] matrix) // вывод массива
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


void equal_matrix1(int[,] first_matrix,int[,] second_matrix,int start,int end)
{
    for(int i = start;i < end;i++)
    {

        for(int k = 0;k < first_matrix.GetLength(1);k++) // столбец
        {

            for(int j = 0;j < first_matrix.GetLength(0);j++)  // строка
            {
                serialMulres[i,k] = first_matrix[i,k] * second_matrix[j,k]; // подсчет конечного результата,serialMulres[i,k] = тоесть с начальной позиции потока(i) начинаем записывать элементы в столбец(k),которые равны смежному произведению первой и второй матрицы
                //first_matrix[i,k] - первый параметр равен i - потому что,для первой матрицы,мы берем элементы из начальной позиции потока,тоесть из нулевого столбца(для первого потока,для второго будет уже другое значение)
                //а для второй матрицы мы берем смежные элементы первой матрицы,тоесть мы умножаем строки первой матрицы на столбцы второй матрицы по диагонали
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
        thread_list.Add(new Thread(() => equal_matrix1(first_matrix,second_matrix,StartPos,EndPos))); // здесь в лист мы добавляем по одному потоку и внутри потока вызываем анонимную функцию(лямбда функцию,которая как раз производит вычисления),передаем туда параметры(элементы первого массива и второго,а так же начальную и конечную позицию,после которой поток остановится и начнет выполнятся следующий)
        thread_list[i].Start(); // запускаем поток,сразу после вычисления
    }
    for(int i = 0;i < Thread;i++)
    {
        thread_list[i].Join(); // присоединение потоков к основному,чтобы они не продолжали свою работу
    }
}


int[,] first_matrixx = RandomGenerator6(N,N); //  заполнение первой матрицы случайными элементами

int[,] second_matrixx = RandomGenerator6(N,N); // завполнение второй матрицы случайными элементами

PrintFunctionn(first_matrix); // вывод первой матрицы

Console.WriteLine();

PrintFunctionn(second_matrix); // вывод второй матрицы

Console.WriteLine();

ParallelMatrix(first_matrixx,second_matrixx); // двумерный массив который будет хранить многопоточное умножение матриц размером [N12,N12],

PrintFunctionn(serialMulres);



