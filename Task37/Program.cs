// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. 

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите размер массива: ");

int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

FillArray(array);
WriteArray(array);
int[] newArr = Multiple(array);
WriteArray(newArr);

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 9);
    }
}

void WriteArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int [] Multiple(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    int[] newArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0)
    newArr[size-1]=arr[arr.Length/2];
    return newArr;
}