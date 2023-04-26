// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Num(string mess) // метод получения размера массива вводом с клавиатуры
{
    int a = new int();
    Console.Write(mess);
    return a = int.Parse(Console.ReadLine()!);
}
long[] Array(int num) // метод создания массива и ввода с клавиатуры значений
{
    long[] arr = new long[num];
        for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите очередное число в массиве: ");
        arr[i] = long.Parse(Console.ReadLine()!);
    }
    return arr;
}
void Res(long[]arr) // метод вывода на экран массива и количества положительных значений в нем
{
    Console.WriteLine();
    Console.Write($"[");
    int count = 0;
    int x = (arr.Length-1);
    for (int i = 0; i < x; i++)
    {
        Console.Write($"{arr[i]}, ");
        if(arr[i]>0)
            count++;
    }
    if(arr[x]>0)
        count++;
    Console.WriteLine($"{arr[x]}] -> {count}");        
}
Res(Array(Num("Введите размер массива: ")));
Console.WriteLine();