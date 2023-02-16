// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetEmptyMatrix()
{
    int[,] matrix = new int[4, 4];
    int element = 1;
    matrix[0,0] = element;
    matrix[0,1] = element + 1;
    matrix[0,2] = element + 2;
    matrix[0,3] = element + 3;
    matrix[1,3] = element + 4;
    matrix[2,3] = element + 5;
    matrix[3,3] = element + 6;
    matrix[3,2] = element + 7;
    matrix[3,1] = element + 8; 
    matrix[3,0] = element + 9;
    matrix[2,0] = element + 10;
    matrix[1,0] = element + 11;
    matrix[1,1] = element + 12;
    matrix[1,2] = element + 13;
    matrix[2,2] = element + 14;
    matrix[2,1] = element + 15;
    return matrix;
}

void PrintArray(int[,] inArray) // Вывод массива на консоль
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int colunm = 0; colunm < inArray.GetLength(1); colunm++)
        {
            Console.Write($"{inArray[row, colunm]}\t ");
        }
        Console.WriteLine();
    }
}

void Main()
{
int[,] matrix = GetEmptyMatrix();
PrintArray(matrix);
}

Main();