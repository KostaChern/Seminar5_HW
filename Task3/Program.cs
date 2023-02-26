// Задача 3: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();
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

int SearchMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)  // находим max
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int SearchMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) // находим min
        {
            min = array[i];
        }
    }
    return min;
}

int size = 10;
int minValue = 0;
int maxValue = 20;
int[] myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);

int max = SearchMax(myArray);
int min = SearchMin(myArray);
System.Console.WriteLine($"разница между MAX и MIN элементом массива ={max - min} ");