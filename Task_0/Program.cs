//Напишите программу, которая на вход принимает число 
//и выдаёт его квадрат (число, умноженное на само себя).

Console.WriteLine("Введите число");
string input = Console.ReadLine(); // ввод в строку
int number = int.Parse(input); // преобразование в число
// if (int.TryParse(input))
int square = number * number; // площадь
Console.WriteLine($"Число в квадрате равно {square}"); // вывод
// Console.WriteLine("Число в квадрате равно {0}", square)