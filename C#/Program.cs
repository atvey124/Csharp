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
while (index < N) // условие цикла так же должно быть в круглых скобках
{
    Console.WriteLine(index); // после чего в фигурных скобках пишутся действия которые будут выполняться пока цикл не будет прерван,тоесть условие нарушиться
    index = index + 1; // итерация в цикле чаще всего выполняется с помощью вспомогающей переменной,которая обозначает - один проход по циклу

}
