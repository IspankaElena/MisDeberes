// Напишите программу которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

//а=5; b=7;
//а=2; b=10;
//а=-9; b=-3;

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("Первое число больше второго");
}
else if(a < b)
{
   Console.WriteLine("Первое число меньше второго"); 
}
Console.ReadKey();