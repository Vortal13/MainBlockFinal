

int NumberOfElements(string[] fistArray)
{
    int count = 0;
    foreach (string item in fistArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void SelectedArray(string[] fistArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < fistArray.Length; i++)
    {
        if (fistArray[i].Length <= 3)
        {
            secondArray[count] = fistArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {        
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Введите количество элементов массива:");
int size = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string[] fistArray = new string[size];
if (size == 0) System.Console.Write("Такого массива не существует.");
else
{
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите элемент №{i}: ");
        fistArray[i] = Console.ReadLine()!;
    }
    System.Console.WriteLine($"Ваш массив: ");
    System.Console.WriteLine(string.Join("; ", fistArray));
}
string[] secondArray = new string[NumberOfElements(fistArray)];

SelectedArray(fistArray, secondArray);
System.Console.WriteLine("Получившийся массив:");
PrintArray(secondArray);
