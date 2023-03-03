int GetIndexArray(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int index = Convert.ToInt32(value);
    return index;
}    

void GetArray(int[,] array, int indexStr, int indexCol)
{
    for(int i = 0; i < indexStr; i++)
    {
        for(int j = 0; j < indexCol; j++)
        array[i, j] = new Random().Next(2, 10);
    }
}

void PrintArray(int[,] array, int indexX, int indexY, int indexStr, int indexCol )
{
    if(indexX <= indexStr && indexY <= indexCol)
            Console.WriteLine($"Искомый элемент = {array[indexX, indexY]}");
        
    else 
        Console.WriteLine("Такого числа в массиве нет");
}


int indexStr = GetIndexArray("Введите количество строк  ");
int indexCol = GetIndexArray("Введите количество столбцов  ");
int[,] array = new int[indexStr, indexCol];
GetArray(array, indexStr, indexCol);

int indexX = GetIndexArray("Введите номер строки искомого элемента   ");
int indexY = GetIndexArray("Введите номер столбца искомого элемента   ");
PrintArray(array, indexX, indexY, indexStr, indexCol);