// Программа, которая находит точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string[] ab = {"b1","k1","b2","k2"};
double[] arr = new double[4];
Console.WriteLine("Введите параметры двух прямых вида y = k * x + b.");
for (int i = 0; i < ab.Length; i++)
{
    Console.Write($"Введите значение {ab[i]} = ");
    arr[i]=double.Parse(Console.ReadLine()!);
}

double x = (arr[2]-arr[0])/(arr[1]-arr[3]);
double y = arr[3]*x+arr[2];

Console.Write($"b1 = {arr[0]}, k1 = {arr[1]}, b2 = {arr[2]}, k2 = {arr[3]} -> ({x} ; {y})");