// 5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от −N до N.

Console.WriteLine("Введите число");
string input = Console.ReadLine(); 
int number = int.Parse(input); 

for (int i = -number; i <= number; i ++) // i < number + 1
Console.WriteLine(i);