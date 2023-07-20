// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

int[] MakeNewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
    }
    return array;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInfo("Введите размер массива: ");

int minValue = GetInfo("Введите начальный диапазон случайных чисел массива: ");

int maxValue = GetInfo("Введите максимальный диапазон случайных чисел массива: ");

int[] array = MakeNewRandomArray(size, minValue, maxValue);

Console.Write($"[{string.Join(", ", array)}] -> {FindSum(array)}");