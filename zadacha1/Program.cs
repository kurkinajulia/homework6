//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] CreateArray(int size) //cоздание массива
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array) //показ массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int GetNumbersOverZero(int[] array) //возвращение количества чисел в массиве больше 0
{
    int numbersOverZero = 0;
    {
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        numbersOverZero++;
    }
    return numbersOverZero;
}
}

Console.Write("Введите размер массива: "); //введение пользователем размера массива
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 1)
{
    Console.WriteLine("Размер массива должен быть больше 1.");
    return;
}
Console.WriteLine("Введите значения массива по одному: "); 
int[] array = CreateArray(size);
Console.Write("Массив заполнен числами: ");
ShowArray(array);
Console.WriteLine($"Количество введённых чисел больше 0: {GetNumbersOverZero(array)}");