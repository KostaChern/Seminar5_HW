// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int OddArray(int[] array)
{
    int oddSum = 0;  
    for (int i = 1; i < array.Length; i = i+2)  //определяем нечетные позиции массива
    {
      oddSum = oddSum + array[i];  // суммируем нечет
    }
    return oddSum;
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

int size = 9;
int minValue = 0;
int maxValue = 10;

int[] myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
int odd = OddArray(myArray);
System.Console.WriteLine( $"сумма элементов на нечетных позициях массива = {odd} ");


