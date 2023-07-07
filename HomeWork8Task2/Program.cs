// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GenerateArray2D(int rows, int columns) // создаем двумерный массив со случайными числами
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(0,10);
        }
    }
    return numbers;
}

    void PrintArray2D(int[,] numbers) // функция вывада массива на консоль
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i,j]}  ");
        }
        System.Console.WriteLine();
    }
}

int[] ArraySumLine(int[,] array) // функция нахождения строки с наименьшей суммой элементов
{
    int [] SumElementLine = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum = sum+ array[i,j];
        }
    SumElementLine[i]= sum;
    }
    return SumElementLine;
}
void PrintArray(int[] array) // функция вывода одномерного массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int MinSumElement(int[] array) // находим номер строки с наименьшей суммой элементов
{
    int min = array[0];
    int minPosition = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minPosition = i;
        }
    }
        return minPosition;
}

int[,] newArray = GenerateArray2D(5,3);
PrintArray2D(newArray);
Console.WriteLine();
int[] sumElementArray = ArraySumLine(newArray);
PrintArray(sumElementArray);
System.Console.WriteLine();
int min = MinSumElement(ArraySumLine(newArray));
System.Console.WriteLine($"Минимальная сумма элементов в {min+1} строке.");

