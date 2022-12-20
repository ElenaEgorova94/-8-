// Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.


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

int[,] CreateSquareArray(int size)
{
    return CreateArray(size, size);
}


int[,] CreateSquareArrayToTen(int size)
{
    return CreateArrayToTen(size, size);
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


var array = CreateSquareArray(Readint());
Console.WriteLine();

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintArraySpiral(array);

void PrintArraySpiral(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
