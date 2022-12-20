// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2 


int[,,] CreateThreeDimensionArray(int firstLength, int secondLength, int thirdLength)
{
    var array = new int[firstLength, secondLength, thirdLength];
    var random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(100);
            }

        }
    }
    return array;
}

void PrintThreeDimensionArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)

                Console.Write(array[i, j, k] + " ");
        }
        Console.WriteLine();
    }
}




var array = CreateThreeDimensionArray(2, 2, 2);
PrintThreeDimensionArray(array);
PrintArrayElementIndex(array);

void PrintArrayElementIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}  ({i}, {j}, {k})");
            }

        }
    }
    Console.WriteLine();
}
