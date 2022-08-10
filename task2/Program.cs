// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Ведите первое число ");
int number1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt16(Console.ReadLine());

if (number1 > number2)
    {
        int max = number1;
        Console.WriteLine("Большее из двух чисел: " + max);
    }
else 
{
    int max = number2;
    Console.WriteLine("Большее из двух чисел: " + max);
}