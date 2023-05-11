// Напишите программу которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

//а=5; b=7;
//а=2; b=10;
//а=-9; b=-3;

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b)
// {
//     Console.WriteLine("Первое число больше второго");
// }
// else if(a < b)
// {
//    Console.WriteLine("Первое число меньше второго"); 
// }
// Console.ReadKey();

// Использование оператора равенства

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// Улучшение проверка для равенства строк с помощью встроенных вспомогательных методов строки

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Использование оператора неравенства

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Вычисление сравнений. Использование операторов сравнения

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// Использование метода, возвращающего логическое значение

// string pangram = "The quick brown fox jumps over the lazy dog.";

// option1 
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// option2
// Использование оператора логического отрицания

// These two lines of code will create the same output

// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// Упражнение. Реализация условного оператора

// Предположим, вам нужно быстро определить, имеет ли клиентская покупка права на рекламную скидку. Сведения о акции указывают, что если стоимость покупки превышает 1000 долл. США, покупка имеет право на скидку в размере 100 долл. США. Если сумма покупки составляет 1000 долл. США или меньше, на покупку распространяется скидка в размере 50 долл. США.
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");