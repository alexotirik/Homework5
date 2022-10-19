/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FillArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(-100, 100);
        Console.Write($"{num[i]}, ");
    }
}
int Max(int[] number)
{
    int result = number[0];
    for (int index = 0; index < number.Length; index++)
    {
        if (result < number[index]) result = number[index];
    }
    return result;
}

int Min(int[] numbers)
{
    int result = numbers[0];
    for (int index = 0; index < numbers.Length; index++)
    {
        if (result > numbers[index]) result = numbers[index];
    }
    return result;
}

int[] array = new int[7];
FillArray(array);
Console.WriteLine();
Console.Write("Максимальное число = ");
Console.WriteLine(Max(array));
Console.Write("Минимальное число = ");
Console.WriteLine(Min(array));
int sum = Max(array) - Min(array);
Console.WriteLine("Разница между элементами = " + sum);