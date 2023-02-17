// // #2Напишите программу, которая на вход принимает 
// // два числа и выдаёт, какое число большее, а какое меньшее.
int num1 = 5;
int num2 = 7;
if(num1 > num2)
{
    Console.WriteLine("max = " + num1);
}
else
{
    Console.WriteLine("max = " + num2);
}

// // #4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int max = 0;
Console.Write("Print first number: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Print second number: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Print third number: ");
int Number3 = Convert.ToInt32(Console.ReadLine());
if(Number1 > max)
{
    max = Number1;
}
if(Number2 > max)
{
    max = Number2;
}
if(Number3 > max)
{
    max = Number3;
}
Console.WriteLine("max = " + max);

// #6Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка)

Console.Write("Print number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Rem = Number % 2;
if(Rem == 0)
{
    Console.WriteLine("число является четным");
}
else
{
    Console.WriteLine("число не является четным");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Print number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int i = 2;
if(Number > 1)
{
    while(i <= Number)
    {
        Console.Write(i + ";");
        i = i + 2;

    }
}  