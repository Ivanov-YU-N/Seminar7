int GetIndexArray(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int index = Convert.ToInt32(value);
    return index;
}

void GetArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(2, 10);
    }
}

void PrintArray(int[,] array, int indexX, int indexY)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    if (indexX <= rows && indexY <= columns)
        Console.WriteLine($"Искомый элемент = {array[indexX, indexY]}");
    else
        Console.WriteLine("Такого числа в массиве нет");
}

int indexStr = GetIndexArray("Введите количество строк  ");
int indexCol = GetIndexArray("Введите количество столбцов  ");
int[,] array = new int[indexStr, indexCol];
GetArray(array);
int indexX = GetIndexArray("Введите номер строки искомого элемента   ");
int indexY = GetIndexArray("Введите номер столбца искомого элемента   ");
PrintArray(array, indexX, indexY);
