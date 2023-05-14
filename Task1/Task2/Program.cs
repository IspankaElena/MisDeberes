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
// Сведения о акции указывают, что если стоимость покупки превышает 1000 долл. США, покупка имеет право на скидку в размере 100 долл. США. Если сумма покупки составляет 1000 долл. США или меньше, на покупку распространяется скидка в размере 50 долл. США.

// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// Использование встроенного условного оператора
// Этот код можно еще больше сжать, ликвидировав временную переменную discount.

// int saleAmount = 1001;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Задача по коду: напишите код для отображения результата переворачивания монеты

// Вероятность того, что результатом будет орел либо решка, должна составлять 50 %.

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// string permission = "Admin|Manager";
// int level = 19;
// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//       Console.WriteLine("Welcome, Super Admin user.");  
//     }
//     else 
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
//     else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//       Console.WriteLine("Contact an Admin for access.");  
//     }
//     else 
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// string используется для вывода слов, фраз и любых других буквенно-цифровых данных, но не для выполнения вычислений с ними;
// char представляет отдельную букву или цифру;
// int представляет целое число;
// decimal для числа с дробным компонентом
// booltrue/false для значения истины и лжи

// string firstName;
// firstName = "Bob";
// Console.WriteLine(firstName);
// firstName = "Liem";
// Console.WriteLine(firstName);
// firstName = "Isabella";
// Console.WriteLine(firstName);
// firstName = "Yasmin";
// Console.WriteLine(firstName);

// Hello, Bob! You have 3 in your inbox. The temperature is 34.4 celsius.

// string name = "Bob";
// int messages = 3;
// decimal temperature = 34.4m;

// Console.Write("Hello, ");
// Console.Write(name);
// Console.Write("! You have ");
// Console.Write(messages);
// Console.Write(" in your inbox. The temperature is ");
// Console.Write(temperature);
// Console.Write(" celsius.");