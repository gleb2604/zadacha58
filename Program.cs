/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
(допустимый вариант)
6 16
9 6
*/
Console.Write("Введите размер строки: ");
int rowsLenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца: ");
int columsLenght = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rowsLenght,columsLenght];
int [,] matrixTwo = new int [rowsLenght,columsLenght];
int [,] resultMatrix = new int [rowsLenght,columsLenght];

getRandomMatrix(matrix);
printMatrix(matrix);
Console.WriteLine();
getRandomMatrix(matrixTwo);
printMatrix(matrixTwo);


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrixTwo.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += matrix[i, k] * matrixTwo[k, j];
        }
    }
}
Console.WriteLine();

printMatrix(resultMatrix);

void getRandomMatrix(int[,] matrix)
{   
    int LeftRange = 0;
    int RightRange = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(LeftRange,RightRange);
        }   
    }
}

void printMatrix(int[,] matrix){
    for(int i = 0; i< matrix.GetLength(0);i++)
    {
        for(int j = 0; j<matrix.GetLength(1);j++)
        {
           Console.Write(matrix[i,j] + " ");
        }
        
        Console.WriteLine();
    }
}