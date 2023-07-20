// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double GetDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
    }
    double diff = max - min;
    return diff;
}

double[] MakeNewRandomDoubleArray(int size) // Как оформить красивей массив (скобочки и запятые)???? Не разобрался
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
        Console.Write($"{array[i]:F2} ");
    }
    return array;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInfo("Введите размер массива: ");

double[] array = MakeNewRandomDoubleArray(size); 

Console.WriteLine($"\nРазница между максимальным и минимальным элементов массива: {GetDiff(array):F2}");