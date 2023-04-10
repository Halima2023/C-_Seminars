// HW_Task_4. Задача 8: Напишите программу, которая на вход принимает  
// число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

while (evenNumber < num)
{
    Console.Write(evenNumber + " "); evenNumber += 2;
}

