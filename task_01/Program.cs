// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}

void SearchPosition(int[,] matrix, int[] position)
{
    int firstPos = position[0];
    int secondPos = position[1];
    if (firstPos < matrix.GetLength(0) && secondPos < matrix.GetLength(1))
        Console.WriteLine(matrix[firstPos, secondPos]);
    else
        Console.WriteLine("Данной позиции нет в массиве");
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int firstRandom = new Random().Next(0, 11);
int secondRandom = new Random().Next(0, 11);
int[,] matrix = new int[firstRandom, secondRandom];

InputMatrix(matrix);

Console.Write("Введите позицию через запятую: ");
int[] position = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();

PrintMatrix(matrix);

Console.WriteLine();
SearchPosition(matrix, position);