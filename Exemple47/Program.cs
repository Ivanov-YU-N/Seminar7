int GetIndexArray(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int index = Convert.ToInt32(value);
    return index;
}    

void GetArray(double[,] array, int indexStr, int indexCol)
{
    for(int i = 0; i < indexStr; i++)
    {
        for(int j = 0; j < indexCol; j++)
        array[i, j] = new Random().Next(2, 10);
    }
}
// Выведем массив для проверки 
void PrintArray(double[,] array, int indexStr, int indexCol)
{
    for(int i = 0; i < indexStr; i++)
    {
        for(int j = 0; j < indexCol; j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    
}


int indexStr = GetIndexArray("Введите количество строк  ");
int indexCol = GetIndexArray("Введите количество столбцов  ");
double[,] array = new double[indexStr, indexCol];
GetArray(array, indexStr, indexCol);
PrintArray(array, indexStr, indexCol);

