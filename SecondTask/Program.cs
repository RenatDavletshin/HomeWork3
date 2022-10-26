// Напишите программу, которая выводит третью цифру заданного числа и сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if(num > 99)
{
    Console.WriteLine(num.ToString()[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}