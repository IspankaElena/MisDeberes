// Напишите программу которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N
// 5->2,4
// 8->2,4,6,8

Console.WriteLine("Введите число N");

int a = Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=a;i++)
{
  if(i % 2 == 0) 
  System.Console.Write(i + " , ");
}

