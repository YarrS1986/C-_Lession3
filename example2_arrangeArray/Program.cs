// Сортировка массива. от минимального к максимальному

Console.Clear();

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

//несколько вариантов.
//вариант 1.
void PrintArray(int[] array) // этот метод задает массив
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // упорядочивает массив
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temprorary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprorary;
    }
}

PrintArray(arr);
SelectionSort(arr);

Console.WriteLine();
PrintArray(arr);