// Нерекурсивное решение.
Console.Clear();

Console.Write("Введите количество чисел: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = CreateArray(number);
FillArray(array);
CountPositive(array);

Console.WriteLine($"Положительных: {CountPositive(array)}");

int[] CreateArray(int num)
{
    int[] arr = new int[num];
    return arr;
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

int CountPositive(int[] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}
