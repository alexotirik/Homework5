/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
        Console.Write($"{numbers[i]}, ");
    }
}

int EvenNumbersCount(int[] num)
{
    int count = 0;
    for (int index = 0; index < num.Length; index++)
    {
        if(num[index] % 2 == 0)
        count++;
        
    }
    return count;
}

//int[] array = {131, 233, 431, 121, 457}; //проверка корректности работы на случай, если нет четных чисел
int[] array = new int[5];
FillArray(array);
Console.WriteLine();
Console.Write("Count = ");
Console.WriteLine(EvenNumbersCount(array));