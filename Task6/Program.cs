// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int ostatok = num % 2;

if (ostatok == 0)
{
    Console.Write("Введеное число является четным");
}
else 
{
    Console.Write("Введеное число не является четным");
}
