int GetIndexArray(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int index = Convert.ToInt32(value);
    return index;
}

void GetArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(2, 10);
    }
}

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{array[i, j]}     ");

        Console.WriteLine();
    }
}

void PrintResult(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int j = 0; j < column; j++)
    {
        int sum = 0;
        double count = 0;
        for (int i = 0; i < row; i++)
        {
            sum += array[i, j];
            count += 1;
        }

        Console.Write($"{Math.Round(sum / count, 1)}   ");
    }
}

int indexRow = GetIndexArray("Введите количество строк  ");
int indexCol = GetIndexArray("Введите количество столбцов  ");
int[,] array = new int[indexRow, indexCol];
GetArray(array);
PrintArray(array);
PrintResult(array);
Console.WriteLine();
