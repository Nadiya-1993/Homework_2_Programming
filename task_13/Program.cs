//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length > 2)
{
    Console.WriteLine("третья цифра = " + numText[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}