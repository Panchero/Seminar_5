// Задача 33: 
// Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// используем bool - true / false

Console.Write ("Введите размер массива: ");

int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

FillArray(array);
WriteArray(array);

Console.Write ("Введите число для поиска в массиве: ");
int FindNumber = Convert.ToInt32(Console.ReadLine());
Console.Write (ArraySearch(array, FindNumber)? "Да" : "Нет");

void FillArray(int[]arr)
{
    Random rand = new Random(); 
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0,1000);
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

bool ArraySearch(int[]arr, int FindNumber)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == FindNumber) return true; // если массив содержити значаение переменной верни Тру
    }
    return false;
}
// bool check = true;
// Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked

// Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked