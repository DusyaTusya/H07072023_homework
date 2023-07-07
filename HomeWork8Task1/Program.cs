// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GenerateArray2D(int rows, int columns)// Создаем массив из случайных чисел
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

void PrintArray2D(int[,] numbers) //функция вывода массива на консоль
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


int[,] SelectionSortMaxArray2D(int[,] array) // функция сортировки элементов массива по убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if(array[i,k] < array[i,k+1])
                {
                    int temporary = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temporary;
                }
                           
            }
        }
    }
    return array;
}

int[,] newArray = GenerateArray2D(3,5);
PrintArray2D(newArray);
Console.WriteLine();
int[,] result = SelectionSortMaxArray2D(newArray);
PrintArray2D(result);

