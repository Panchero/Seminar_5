// Задача 32: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write ("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize]; //создаем массив с нулями
FillArray(array);
WriteArray(array);
EditArray(array);
WriteArray(array);
void FillArray(int[]arr)
{
    Random rand = new Random(); 
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10,10);
    }
}

void WriteArray(int[]arr)
{
Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write ($"{arr[i]}, "); 
    else Console.Write ($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void EditArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]*= -1;
    }
}