// HW_Task_1. Зaдача 2. Напишите программу, которая  на вход принимает два числа и
// выдает какое число большее, а какое меньшее.

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
int min = num2;

if (num1 > num2) max = num1;
else max = num2;
if (num1 < num2) min = num1;
else min = num2;

Console.WriteLine("The larger number is " + max);
Console.WriteLine("The smaller number is " + min);
