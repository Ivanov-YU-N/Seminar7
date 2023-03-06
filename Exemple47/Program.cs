int GetIndexArray(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int index = Convert.ToInt32(value);
    return index;
}

void GetArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(2, 10);
    }
}

// Выведем массив для проверки
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int indexStr = GetIndexArray("Введите количество строк  ");
int indexCol = GetIndexArray("Введите количество столбцов  ");
double[,] array = new double[indexStr, indexCol];
GetArray(array);
PrintArray(array);
