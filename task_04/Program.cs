// (не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива. Под удалением 
// понимается создание нового двумерного массива без строки и столбца

Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
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

void MinPosition(int[,] matrix, out int minRow, out int minCol)
{
    int minValue = int.MaxValue;
    minRow = -1;
    minCol = -1;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] < minValue)
            {
                minValue = matrix[i,j];
                minRow = i;
                minCol = j;
            }
        }
    }
}

void NewMatrix(int[,] matrix, int[,] newMatrix, int minRow, int minCol)
{
    int newRow=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i==minRow)
        {
            continue;
        }

        int newCol=0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j==minCol)
            {
                continue;
            }
            newMatrix[newRow, newCol] = matrix[i, j];
            newCol++;
        }
        newRow++;
    }
}

int random = new Random().Next(3, 5);
int length = random;

int[,] matrix = new int[length, length];
InputMatrix(matrix);
PrintMatrix(matrix);

int minRow, minColumn;
MinPosition(matrix, out minRow, out minColumn);
Console.WriteLine();
Console.WriteLine($"The minimum value is at row {minRow+1}, column {minColumn+1}");

int[,] newMatrix = new int[length-1, length-1];
NewMatrix(matrix, newMatrix, minRow, minColumn);
Console.WriteLine("new matrix: ");
PrintMatrix(newMatrix);