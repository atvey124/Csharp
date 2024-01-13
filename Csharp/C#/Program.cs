﻿                                                                                        // типы данных в c#
int integer = 1245; // цело численные
bool boolian = false; // логические значения true false 
char character = '!'; // знаки,пишутся внутри ''
double double1 = 5.55; // дробные 
string string1 = "Hi"; // строки
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




                                                                                        // методы
int i = 1;
                                                                                     
Console.WriteLine(i); // данный метод позволяет вывести что-либо в терминал по вертикале
Console.Write(i); // данный метод позволяет вывести что либо в терминал по горизонтали
Console.Write(' '); // так же в данный метод можно вывести такой тип данных как char,можно вывести любой тип данных


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
Console.Write("Введите число N,между -N и N будут показаны все целые: ");
int N_number = int.Parse(Console.ReadLine()!);
int count = -N_number;
while (count != N_number + 1)
{   
    Console.Write(count + " ");
    count++;  // метод эквивалентный += в python,или же эквивалент count = count + 1   
}


// и еще одна задача с использованием конвертора To в данном случае ToString()
int test3 = 543; 
string Str_test3 = test3.ToString(); // перевод типа данных int в string 

int sum_num2 = Str_test3[0] + Str_test3[-1]; // результат



Console.WriteLine("Ответ: ");
Console.Write(sum_num2);