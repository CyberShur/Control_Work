Console.Write("Введите количество проверяемых элементов: ");
int length = Convert.ToInt32(Console.ReadLine());

string[] inputArray = new string[length];

for (int i = 0; i < inputArray.Length; i++)
{
    Console.Write($"Введите {i+1}-й элемент: ");
    inputArray[i] = Console.ReadLine();
}

string[] resultArray = new string[inputArray.Length];

Console.WriteLine();
Console.WriteLine("Входящий массив: ");
PrintArray(inputArray);
Console.WriteLine();

ResultArray (inputArray, resultArray);

Console.WriteLine("Итоговый массив: ");
PrintArray(resultArray);

void ResultArray (string[] array, string[] result)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

