// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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



void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        var row = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }

        Array.Sort(row);

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = row[j];
        }
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


int GetSum(int[,] arr, int rowNumber)
{
    var sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum += arr[rowNumber, i];
    }
    return sum;
}




void PrintArrayRow(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");


    }

    Console.WriteLine();
}



var arr = CreateSquareArray(Readint());
PrintArray(arr);

var sums = new Dictionary<int, int>();

for (int i = 0; i < arr.GetLength(0); i++)
{
    sums[GetSum(arr, i)] = i;
}

var summedArray = sums.Keys.ToArray();
Array.Sort(summedArray);

var row = new int[arr.GetLength(1)];
for (int i = 0; i < row.Length; i++)
{
    row[i] = arr[sums[summedArray[0]], i];
}

Console.WriteLine("Строка с минимальной суммой элементов:");
Console.WriteLine();
PrintArrayRow(row);
    