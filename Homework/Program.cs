// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int result = num1;

// for (int iteration = 1; iteration < num2; iteration++)
// {
//     result = result * num1;
// }
// Console.WriteLine(result);







// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void digitsCount(int num)
{
    int i = 0;
    int num2 = 0;

    while (num2 > 0) // считаем, сколько знаков в числе
    {
        i = i + 1;
        num2 = num / 10;
    }
    Console.WriteLine(i);

}
digitsCount(num);
// sumOfDigits(num, i);


void sumOfDigits(int num, int y)
{
    int index = 0;
    int num2 = 0;
    int result = 0;
    while (index < y)
    {

        result = result + num % 10;
        index++;
        num = num / 10;
    }
    Console.WriteLine(result);

}
