// 1. Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите первое число");
string input1 = Console.ReadLine(); 
int number1 = int.Parse(input1); 
Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine(); 
int number2 = int.Parse(input2); 

int result = number1 / number2; 
if (result == number2)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}