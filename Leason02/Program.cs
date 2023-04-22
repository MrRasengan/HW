//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите три числа: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());
if(numberA > numberB & numberA > numberC)
{
    Console.WriteLine("Максимальное число " + numberA);
}
if(numberB > numberA & numberB > numberC)
{
    Console.WriteLine("Максимальное число " + numberB);
}
if(numberC > numberA & numberC > numberB)
{
    Console.WriteLine("Максимальное число " + numberC);
}
