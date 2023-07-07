// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

int[,] GenerateMatrix1(int rows, int columns) // Создаем первую матрицу
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(2,4);
        }
    }
    return numbers;
}


int[,] GenerateMatrix2(int rows, int columns) // Создаем вторую матрицу
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(2,4);
        }
    }
    return numbers;
}

int[,] NewMatrix(int[,] array1, int[,] array2)// собираем матрицу после перемножения первых двух
{
    int[,] number = new int[array2.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        int m = 0;
        int n = 1;
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            number[i,j] = array1[i,m] * array2[m,j] + array1[i,n] * array2[n,j];
        }
    } 
    return number;
}

void PrintMatrix1(int[,] numbers)// функция вывода матрицы на экран
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


int[,] newArray1 = GenerateMatrix1(2,2);
PrintMatrix1(newArray1);
Console.WriteLine();
int[,] newArray2 = GenerateMatrix2(2,3);
PrintMatrix1(newArray2);
Console.WriteLine();
int[,] newMatrix = NewMatrix(newArray1, newArray2);
PrintMatrix1(newMatrix);