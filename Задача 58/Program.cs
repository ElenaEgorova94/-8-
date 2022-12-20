// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Readint()
{
    Console.WriteLine("Введите значение размера массива");
    int a = int.Parse(Console.ReadLine());
    return a;
}


int[,] CreateArray(int firstLength, int secondLength)
{
    var array = new int[firstLength, secondLength];
    var random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(100);
        }
    }
    return array;
}




void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] CreateArrayToTen(int firstLength, int secondLength)
{
    var array = new int[firstLength, secondLength];
    var random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10);
        }
    }
    return array;
}


int[,] CreateSquareArray(int size)
{
    return CreateArray(size, size);
}

int[,] CreateSquareArrayToTen(int size)
{
    return CreateArrayToTen(size, size);
}




var firstArray = CreateSquareArrayToTen(2);
PrintArray(firstArray);
Console.WriteLine();
var secondArray = CreateSquareArrayToTen(2);
PrintArray(secondArray);
Console.WriteLine();
var resultArray = CreateSquareArrayToTen(2);
MultiplicationArray(firstArray, secondArray, resultArray);
Console.WriteLine();
PrintArray(resultArray);
Console.WriteLine();

void MultiplicationArray(int[,] arrayOne, int[,] arrayTwo, int[,] resultArray)
{

    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = sum;
        }
    }

}

