// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int numberA = 2;
while(numberA <= number)
{
    Console.WriteLine(numberA + " ");
    numberA = numberA + 2;
}