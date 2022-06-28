//Сравнение двух чисел
Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
Console.WriteLine($"{num1} - большее число");
else
Console.WriteLine($"{num2} - большее число");
