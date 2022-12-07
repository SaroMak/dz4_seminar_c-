// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] SetArray(int size, int leftRange, int rightRange) // 
{
    Random rand = new Random();

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)

    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }

    return arr;
}

int[] array = SetArray(8, -100, 100);

Console.WriteLine($"[{string.Join(" | ", array)}]");