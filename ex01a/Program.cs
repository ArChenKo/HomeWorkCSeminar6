// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Строки.

Console.Write("Введите строку с числами через запятую: ");
string numbers = Console.ReadLine()!;
int[] Arr(string numbers)
{
    string[] chisla = numbers.Split(',');
    int[] arrnum = new int[chisla.Length];
    for (int i = 0; i < chisla.Length; i++)
    {
        arrnum[i] = int.Parse(chisla[i]);
    }
    return arrnum;
}
int Num(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {        
        if (array[i] > 0)
            count++;
    }    
    return count;
}
Console.WriteLine($"{numbers} -> {Num(Arr(numbers))}");