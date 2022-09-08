// 7. Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
string input = Console.ReadLine(); 
int number = int.Parse(input); 
// int digit = number % 10;
Console.WriteLine(number % 10);

// string threeDigitNumber = Console.ReadLine();
// Console.WriteLine(threeDigitNumber[2]);