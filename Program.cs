/*
Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Ввведите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печать чисел от M до N
/// Cумма натуральных элементов в промежутке от M до N
/// </summary>
/// <param name="start"> левая граница (M) </param>
/// <param name="end"> правая граница (N) </param>
/// <returns> строчку с числами от M до N 
/// сумма натуральных элементов в промежутке от M до N </returns>
int sum = 0;
string GetTheSumOfElementsInInterval(int start, int end)
{
    // Базовый случай - выход
    sum += start;
    if (start == end)  return start.ToString(); // Вернул последнее число в формате строчки
    // Рекурсивный случай
    
    return start + ", " + GetTheSumOfElementsInInterval(start + 1, end);
    
}
Console.WriteLine();
Console.WriteLine($"Все натуральные числа в промежутке от {M} до {N} :");
Console.WriteLine(GetTheSumOfElementsInInterval(M, N)); // start = M, end = N
Console.WriteLine($"Сумма этих чисел = {sum}");