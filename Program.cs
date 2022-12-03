// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
    Console.Write(num1);
}
else
{
    Console.Write(num2);
}


//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input a number:");
int num11 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int num22 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number:");
int num33 = Convert.ToInt32(Console.ReadLine());

if(num11>num22)
{
    if(num11>num33)
    {
        Console.Write(num11);
    }
    else
    {
        Console.Write(num33);
    }
}
else
{
    if(num22>num33)
    {
        Console.Write(num22);
    }
    else
    {
        Console.Write(num33);
    }
}



// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int num111 = Convert.ToInt32(Console.ReadLine());

if(num111 % 2 == 0)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}



// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int step = 2;
Console.Write("Input a number: ");
int all_num = Convert.ToInt32(Console.ReadLine());
if(all_num % 2 > 0)
{
    all_num = all_num - 1;
}

Console.Write(step + " ");

while(step < all_num)
{
    if(step % 2 == 0)
    {
        step = step + 2;
        Console.Write(step + " ");
    }
}
