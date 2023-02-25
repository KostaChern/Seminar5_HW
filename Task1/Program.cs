// Задача 1: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Clear();


int HonestArray(int[] array)
{
    int sum = 0;  // Сумма накопления
    for (int i = 0; i < array.Length; i++) // цикл перебора по массиву
    {

        if (array[i] % 2 == 0)
        {
            sum++;             // накапливаем сумму
        }


    }
    return sum;
}


int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}


int size = 12;
int minValue = 100;
int maxValue = 1000;

int[] myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
int Honest = HonestArray(myArray);
System.Console.WriteLine( $"сумма четных элементов массива = {Honest} ");




