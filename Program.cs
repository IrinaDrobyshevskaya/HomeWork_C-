//Напишите программу, которая на вход принимает два
//числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7

/* Console.WriteLine("Ведите число");
int number1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число");
int number2 =Convert.ToInt32(Console.ReadLine());
 
if (number1>number2)
 {
    Console.WriteLine("max = " +number1);
    Console.WriteLine("min = " +number2);
 }
 else  
 {
    Console.WriteLine("max = " +number2);
    Console.WriteLine("min = " +number1);
 }  */


//Напишите программу, которая принимает на вход
//три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7

/* Console.WriteLine("Ведите число");
int number1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число");
int number2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число");
int number3 =Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine("max: " + number1);
    }
    else
    {
        Console.WriteLine("max: " + number3);
    }
}
 else if (number2 > number3)
{
    Console.WriteLine("max: " + number2);
}
else
{
    Console.WriteLine("max: " + number3);
} */

//Напишите программу, которая на вход принимает
//число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет

/* Console.WriteLine("Ведите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 %2 == 1)
{
    Console.WriteLine("Число " +number1 +" является нечётным");
}
else
{
    Console.WriteLine("Число " +number1 +" является чётным");
} */


///4.Напишите программу, которая на вход принимает
//число (N), а на выходе показывает все чётные 
//числа от 1 до N.

/* Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int count =1;

Console.WriteLine("Чётные числа 1 - " + number1);
while (count<=number1)
{
    if (count %2!=1)
    {
        Console.WriteLine(count + " ");
    }
    count++;
} */


The End!