//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

//int number = new Random().Next(100, 1000); - программа для случайного трехзначного числа
//Console.WriteLine(number);

Console.WriteLine(" введите число от 100 до 999: ");
int number = int.Parse(Console.ReadLine());

int number2 = number % 100;

int number3 = number2 / 10;
Console.WriteLine(number3);
