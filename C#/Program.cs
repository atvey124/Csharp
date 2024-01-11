// типы данных в c#
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
Console.WriteLine(results); // новая переменная будет иметь тип данных 'int',поскольку в бинарной операции два операнда имеют одинокавый тип данных


int integer_num = 10;
double double_num = 10.5;
double sum_integer_double = integer_num + double_num; // в случае если типы данных у операндов будут разные,результат будет иметь тип данных того операнда,который имеет более широкий спектр возможностей(более вместительный операнд)
Console.WriteLine(sum_integer_double); // в результате этого произведения результат(переменная sum_integer_double) будет иметь тип данных 'double',поскольку является более вместитльным 

long long_num = 1000;
int integer_num1 = 15;
long sum_long_integer = long_num + integer_num1; 
Console.WriteLine(sum_long_integer); // в этом случае результат произведения(переменная sum_long_integer) будет иметь тип данных 'long',по той же причине

