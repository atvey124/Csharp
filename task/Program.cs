﻿// еще одна задача с использованием функции(void),где пользователь вводит длину массива и он заполнятся случайными числами типа 'int' 
void task1(int[] arr) // создание массива и передача в параметр массива
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
int count = int.Parse(Console.ReadLine()); // задание длины массива
Random rnd = new(); // создание переменной которая будет генерировать случайные числа
int[] new_massive = new int[count]; // создание массива и передача туда длины которую введете пользователь
int i = 0; // счетчик
Console.Write("Ваш массив:" + "[ ");
while ( i < count) // пока счетчик не станет равным длине которую ввел пользователь
{
    new_massive[i] = rnd.Next(1,15); // каждый круг будем вносить случайное число в массив,в индекс 'i'
    Console.Write(new_massive[i] + " "); // вывод случайных чисел которые сгенерировались
    i++; // увеличение счетчика на 1
}
Console.WriteLine("]");
Console.Write("Ответ: ");
    
task1(new_massive); // функция возведения в квадрат всех случайных чисел в массиве
PrintVoid(new_massive); // вывод возведенных элементов массива


